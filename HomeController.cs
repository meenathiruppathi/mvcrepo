using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcapplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mvcapplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.greeting = hour < 12 ? "Good Morning, Time is" + DateTime.Now.ToShortTimeString() : "Good Afternoon. Time is" + DateTime.Now.ToShortTimeString();


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
