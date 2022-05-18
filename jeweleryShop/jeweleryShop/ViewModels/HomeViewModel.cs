using System;
using System.Collections.Generic;
using jeweleryShop.Data.Models;

namespace jeweleryShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> popularProduct { get; set; }
    }
}
