﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
            public Product(bool stock = true)
            {
                InStock = stock;
            }
       
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Cost { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; } = true;

        public static Product[] GetProduct()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Cost = 275M
            };
            Product lifejacket = new Product
            {
                Name = "lifejacket",
                Cost = 48.95M
            };

            kayak.Related = lifejacket;

            return new Product[]
            {
                kayak, lifejacket, null
            };
        }
    }
}
