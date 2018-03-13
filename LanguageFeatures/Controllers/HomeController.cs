using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;
using System.Collections;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
       
        //public ViewResult Index()
        //{
        //    ShoppingCart cart = new ShoppingCart { Products = Product.GetProduct() };
        //    decimal cartTotal = cart.TotalPrices();
        //    return View("Index", new string[] { $"Total: {cartTotal:c2}" });
        //}

        //public ViewResult Index()
        //{
        //    ShoppingCart cart = new ShoppingCart
        //    {
        //        Products = Product.GetProduct()
        //    };
        //    Product[] productArray =
        //    {
        //        new Product
        //        {
        //            Name = "Kayak", Price = 275M },
        //        new Product
        //        {
        //            Name = "LifeJacket", Price = 48.95M }
        //    };
        //    decimal cartTotal = cart.TotalPrices();
        //    decimal arrayTotal = productArray.TotalPrices();
        //    return View("Index", new string[] {
        //        $"Cart Total: {cartTotal:c2}",$"Array total: {arrayTotal:c2}" 
        //    });
        //} 

        public ViewResult Index()
        {
            Product[] productArray =
            {
                new Product {Name = "kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M},
            };


            decimal priceFilterTotal = productArray
                .Filter(p => (p?.Price ?? 0) >= 20)
                .TotalPrices();

            decimal nameFiltertotal = productArray
               .Filter(p => p?.Name?[0] == 'S')
               .TotalPrices();

            return View("Index", new string[] { $"Array Total: {arraytotal:c2}", $"Name Total: {nametotal:c2}" });
        }
    }
}
