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
        public ViewResult Index()
        {
            var products = new[]
            {
                new {Name="Kayak", Cost = 275M},
                new {Name="Lifejacket", Cost = 48.95M},
                new {Name="Soccer ball", Cost = 19.50M},
                new {Name="Corner flag", Cost = 34.95M},
            };
            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Cost)} : {p.Cost}"));
        }
    }
}
