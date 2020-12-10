using eShop.Business.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebUI.Controllers
{//ARTIK KULLANILMIYOR VIEWCOMPONENT KULLANIYORUZ.
    public class NavigationController : Controller
    {
        private ICategoryService categoryService;

        public NavigationController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IActionResult GetMenu()
        {
            var categories = categoryService.GetCategories();



            return View();
        }
    }
}
