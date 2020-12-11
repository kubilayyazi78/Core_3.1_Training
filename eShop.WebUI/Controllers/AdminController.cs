using eShop.Business.Services;
using eShop.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService productService;
        private ICategoryService categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);
        }

        public IActionResult Edit(int id)
        {
            var produtct = productService.GetProductById(id);

            if (produtct == null)
            {
                return NotFound();
            }

            ViewBag.Kategoriler = new SelectList(categoryService.GetCategories(), "Id", "CategoryName");

            return PartialView(produtct);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.UpdateProduct(product);
                return Json("OK");
            }

            return View("Bir Sorun Oluştu");
           
        }
    }
}
