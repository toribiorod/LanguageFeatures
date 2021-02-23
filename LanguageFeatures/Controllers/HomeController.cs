using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        /*  public ViewResult Index()
          {
              return View(new String[] { "C#","Languajes","Features"});
          }*/
        public ViewResult Index()
        {
            ShoppingCart cart
           = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
            new Product {Name = "Kayak", Price = 275M},
            new Product {Name = "Lifejacket", Price = 48.95M},
            new Product {Name = "Soccer ball", Price = 19.50M},
            new Product {Name = "Corner flag", Price = 34.95M}
            };
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });
        }
    }
}
