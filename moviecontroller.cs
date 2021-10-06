using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcapplication.Controllers
{
    public class moviecontroller : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
