using System;
using System.Collections.Generic;
using jeweleryShop.Data.Models;

namespace jeweleryShop.Data.Interfaces
{
    public interface IProducts
    {
        IEnumerable<Product> AllProducts { get; }

        IEnumerable<Product> getPopulars { get; set; }

        Product getProduct(int productID);

    }
}
