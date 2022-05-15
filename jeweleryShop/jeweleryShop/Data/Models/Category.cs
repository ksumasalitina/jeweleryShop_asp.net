using System;
using System.Collections.Generic;

namespace jeweleryShop.Data.Models
{
    public class Category
    {
        public int id { set; get; }

        public string categoryName { set; get; }

        public string description { set; get; }

        public List<Product> products { set; get; }

    }
}
