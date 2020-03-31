using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;

namespace GroupProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult ShoppingCart()
        {
            ViewData["Message"] = "Your shopping cart page.";

            return View();
        }

        public IActionResult Order()
        {
            ViewData["Message"] = "Your order page.";

            return View();
        }

        public IActionResult OrderSuccess()
        {
            ViewData["Message"] = "Your order success page.";

            return View();
        }

        public IActionResult Newsletter()
        {
            ViewData["Message"] = "Your newsletter page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
