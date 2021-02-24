using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        /*  public ViewResult Index()
          {
              return View(new String[] { "C#","Languajes","Features"});
          }*/
        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }
        /* public ViewResult Index()
         {
             /*  ShoppingCart cart
              = new ShoppingCart { Products = Product.GetProducts() };
               Product[] productArray = {
               new Product {Name = "Kayak", Price = 275M},
               new Product {Name = "Lifejacket", Price = 48.95M},
               new Product {Name = "Soccer ball", Price = 19.50M},
               new Product {Name = "Corner flag", Price = 34.95M}
               };*/
        /*decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
        return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });*/
        /*decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
        decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();*/
        /*Func<Product, bool> nameFilter = delegate (Product prod) {
            return prod?.Name?[0] == 'S';
        };
        decimal priceFilterTotal = productArray
        .Filter(p => (p?.Price ?? 0) >= 20)
        .TotalPrices();
        decimal nameFilterTotal = productArray
        .Filter(p => p?.Name?[0] == 'S')
        .TotalPrices();
        return View("Index", new string[] {
        $"Price Total: {priceFilterTotal:C2}",
        $"Name Total: {nameFilterTotal:C2}" });*/
        /* var products = new[] {
     new { Name = "Kayak", Price = 275M },
     new { Name = "Lifejacket", Price = 48.95M },
     new { Name = "Soccer ball", Price = 19.50M },
     new { Name = "Corner flag", Price = 34.95M }
     };
         //return View(products.Select(p => p.Name));
         return View(products.Select(p => p.GetType().Name));
     }*/

        /* public async Task<ViewResult> Index() {
             long? length = await MyAsyncMethods.GetPageLength();
             return View(new string[] { $"Length:{ length}"});
         }*/
        public ViewResult Index()
        {
            var products = new[] {
            new { Name = "Kayak", Price = 275M },
            new { Name = "Lifejacket", Price = 48.95M },
            new { Name = "Soccer ball", Price = 19.50M },
            new { Name = "Corner flag", Price = 34.95M }
            };
            //return View(products.Select(p => $"Name: {p.name}, Price: {p.Price}"));
            return View(products.Select(p =>
            $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}
