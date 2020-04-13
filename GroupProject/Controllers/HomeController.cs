using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;
using GroupProject.Data;

namespace GroupProject.Controllers
{
    public class HomeController : Controller
    {      

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            ViewData["Message"] = "Your products page.";

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

        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Order([Bind("OrderId,FirstName,LastName,Address,City,State,Zip,CardNumber,Month,Year,CVCProductId")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(OrderSuccess));
            }
            return View(order);
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Newsletter([Bind("NewslettterId,FirstName,LastName,Email")] Newsletter newsletter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newsletter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NewsletterSuccess));
            }
            return View(newsletter);
        }

        public IActionResult NewsletterSuccess()
        {
            ViewData["Message"] = "Your newsletter success page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
