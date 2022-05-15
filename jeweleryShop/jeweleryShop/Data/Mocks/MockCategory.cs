using System;
using System.Collections.Generic;
using jeweleryShop.Data.Interfaces;
using jeweleryShop.Data.Models;

namespace jeweleryShop.Data.Mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Кольца", description = "Украшения на пальцы"},
                    new Category{categoryName = "Серьги", description = "Украшения на уши"},
                    new Category{categoryName = "Ожерелья", description = "Украшения на шею"},
                    new Category{categoryName = "Браслеты", description = "Украшения на запястье"}
                };
            }
        }
    }
}
