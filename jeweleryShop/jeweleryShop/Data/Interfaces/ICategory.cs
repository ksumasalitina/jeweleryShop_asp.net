using System;
using System.Collections.Generic;
using jeweleryShop.Data.Models;

namespace jeweleryShop.Data.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
