using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeweleryShop.Data.Interfaces;
using jeweleryShop.ViewModels;
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
            ViewBag.Title = "Jewelery catalog";
            ProductCatalogViewModel obj = new ProductCatalogViewModel();
            obj.AllProducts = _allProducts.AllProducts;
            obj.currCategory = "mg[rb";
            return View(obj);
        }
    }
}
