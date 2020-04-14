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
    public class CartController : Controller
    {
        private IProductRepository repository; 

        public CartController(IProductRepository repo)
        {
            repository = repo;
        }

        public RedirectToActionResult AddToCart(int productID, string returnUrl)
        {
            productID product = repository.Products
                .FirstOrDefault(p => p.ProductID == productID);

            if (product != null)
            {
                Cart cart = GetCart();
                cart.AddItem(product, 1);
                SaveCart(cart);
            }

            return RedirectToAction("Index", new { returnUrl });

        }

        public RedirectToActionResult RemoveFromCart(int productID, string returnUrl)
        {
            productID product = repository.Products
                .FirstOrDefault(product => p.ProductID == productID);

            if (product != null)
            {
                Cart cart = GetCart();
                cart.RemoveLine(product);
                SaveCart(cart);
            }

            return RedirectToAction("Index", new { returnUrl });

        }

        private CartController GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<cart>("Cart") ?? new Cart();
            return cart;
;        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

    }
}