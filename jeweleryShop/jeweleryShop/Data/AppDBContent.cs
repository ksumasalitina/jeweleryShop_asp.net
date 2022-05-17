using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeweleryShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace jeweleryShop.Data
{
    public class AppDBContent : DbContext 
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {
           
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
