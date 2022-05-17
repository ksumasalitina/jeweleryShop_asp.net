using System;
using System.Collections.Generic;
using jeweleryShop.Data.Interfaces;
using jeweleryShop.Data.Models;

namespace jeweleryShop.Data.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
