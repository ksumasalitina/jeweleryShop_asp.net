using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeweleryShop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace jeweleryShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProducts _allProducts;
        private readonly ICategory _allCategories;

        public ProductsController(IProducts iProducts, ICategory iCat)
        {
            _allProducts = iProducts;
            _allCategories = iCat;
        }

        public ViewResult Catalog()
        {
            var prods = _allProducts.AllProducts;
            return View(prods);
        }
    }
}
