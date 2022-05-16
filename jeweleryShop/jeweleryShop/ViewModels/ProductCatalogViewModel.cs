using System;
using System.Collections.Generic;
using jeweleryShop.Data.Models;

namespace jeweleryShop.ViewModels
{
    public class ProductCatalogViewModel
    {
        
        public IEnumerable<Product> AllProducts { get; set; }

        public string currCategory { get; set; }

    }
}
