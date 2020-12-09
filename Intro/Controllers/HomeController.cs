using Intro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Saat = DateTime.Now.Hour;
            ViewBag.Isım = "Kubilay";

            List<Product> products = new List<Product>
            {
                 new Product
                 {
                      Id=1,
                      Vendor="Milla",
                       Description="Pijama",
                        ImageUrl="www.google.com",
                        Price=10
                 },
                  new Product
                 {
                      Id=2,
                      Vendor="Milla",
                       Description="Pijama",
                        ImageUrl="www.google.com",
                        Price=20
                 },
                   new Product
                 {
                      Id=3,
                      Vendor="Milla",
                       Description="Pijama",
                        ImageUrl="www.google.com",
                        Price=30
                 }
            };
            return View(products);
        }


        [HttpGet]
        public IActionResult Cevap()
        {

            List<SelectListItem> items = new List<SelectListItem>()
            {
                new SelectListItem{Text="Geliyorum", Value=bool.TrueString},
                new SelectListItem{Text="Gelmiyorum",Value=bool.FalseString},
            };
            ViewBag.Yanitlar = items.AsEnumerable();

            return View();
        }

        [HttpPost]
        public IActionResult Cevap(KullaniciYanit kullaniciYanit)
        {
            //Model Binder: html inputların isimlerinden (name) özelliklerinden hareketle  KullaniciYanit gibi nesneleri inşa eder.
            if (ModelState.IsValid)
            {
                //sorun yok dbye ekleriz
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}
