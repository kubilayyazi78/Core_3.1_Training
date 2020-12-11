using eShop.Business.Services;
using eShop.WebUI.Extensions;
using eShop.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductService productService;

        public IActionResult Index()
        {
            var sepetIslemleri = GetFromSession();
            return View(sepetIslemleri);
        }

        public CartController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult AddToCart(int id)
        {
            var product = productService.GetProductById(id);
            if (product != null)
            {
                CartList cartList = GetFromSession();
                cartList.AddToCart(product, 1);
                SaveToSession(cartList);
            }
            return Json(product.Name); ;
        }

        public CartList GetFromSession()
        {
            //sepet nesnesi doluysa cartlist e çevir boş ise instance döndür
            CartList cartList = HttpContext.Session.GetJson<CartList>("sepetim") ?? new CartList();
            return cartList;
        }
        public void SaveToSession(CartList cartList)
        {
            HttpContext.Session.SetJson("sepetim", cartList);
        }
    }
}
