﻿using System.Collections.Generic;
using System.Collections;
namespace LanguageFeatures.Models
{
    public class ShoppingCart : IEnumerable<Product>
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    //public IEnumerable<Product> Products { get; set; }

}
