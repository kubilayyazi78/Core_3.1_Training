using eShop.Business.Services;
using eShop.Domain;
using eShop.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            //ProductService productService = new ProductService();
            //productService.GetProducts();
            _logger = logger;
            this.productService = productService;
           
        }
        public int PageSize { get; set; } = 3;
        public IActionResult Index(int page = 1, int category = 0)
        {
            //var products = productService.GetProducts();

            //var product = productService.GetProductsByCategoryId(category==0 || );

            IEnumerable<Product> products = null;
            if (category == 0)
            {
                products = productService.GetProducts();
            }
            else
            {
                products = productService.GetProductsByCategoryId(category);
            }

            var pagingProducts = products.OrderBy(x => x.Id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize);


            PagingInfo pagingInfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsCount = products.Count(),
                PageSize = this.PageSize
            };

            ProductViewModel viewModel = new ProductViewModel
            {
                PagingInfo = pagingInfo,
                Products = pagingProducts,
                 CategoryId=category
            };


            //var totalProductCount = products.Count();
            // var totalPages = (int)Math.Ceiling((decimal)totalProductCount / PageSize);
            //   ViewBag.Pages = totalPages;

            return View(viewModel);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
