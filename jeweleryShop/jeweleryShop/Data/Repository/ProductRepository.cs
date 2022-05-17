using System;
using System.Collections.Generic;
using System.Linq;
using jeweleryShop.Data.Interfaces;
using jeweleryShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace jeweleryShop.Data.Repository
{
    public class ProductRepository : IProducts
    {
        private readonly AppDBContent appDBContent;

        public ProductRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Product> AllProducts => appDBContent.Product.Include(x => x.Category);

        public IEnumerable<Product> getPopulars => appDBContent.Product.Where(p => p.isPopular).Include(x => x.Category);


        public Product getProduct(int productID) => appDBContent.Product.FirstOrDefault(x => x.id == productID);
        
    }
}
