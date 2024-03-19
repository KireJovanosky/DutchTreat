using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchCore.Controllers
{
    public class AppController : Controller 
    {
        public IActionResult Index()
        {
            //throw new InvalidProgramException("Bad thing happen to good programmers");
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About";

            return View();
        }
    }
}
