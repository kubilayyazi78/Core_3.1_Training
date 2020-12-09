using DependencyInversion.Models;
using DependencyInversion.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GuidDataService guidDataService;
        private readonly ITransientGenerator transientGenerator;
        private readonly IScopedGenerator scopedGenerator;
        private readonly ISingletonGuid singletonGuid;
        private readonly IGonderici gonderici;

        public HomeController(ILogger<HomeController> logger,GuidDataService guidDataService , ITransientGenerator transientGenerator, IScopedGenerator scopedGenerator ,ISingletonGuid singletonGuid)              //IGonderici gonderici)
        {
            _logger = logger;
            //this.gonderici = gonderici;


            this.guidDataService = guidDataService;
            this.transientGenerator = transientGenerator;
            this.scopedGenerator = scopedGenerator;
            this.singletonGuid = singletonGuid;

        }

        public IActionResult Index()
        {
            // var result = gonderici.Gonder();
            //  ViewBag.Result = result;

            ViewBag.Transient = transientGenerator.Guid.ToString();
            ViewBag.Scoped = scopedGenerator.Guid.ToString();
            ViewBag.Singleton = singletonGuid.Guid.ToString();

            ViewBag.STransient = guidDataService.transientGenerator.Guid.ToString();
            ViewBag.SScoped = guidDataService.scopedGenerator.Guid.ToString();
            ViewBag.SSingleton = guidDataService.singletonGuid.Guid.ToString();


            return View();
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
