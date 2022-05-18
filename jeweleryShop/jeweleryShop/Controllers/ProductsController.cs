using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeweleryShop.Data.Interfaces;
using jeweleryShop.Data.Models;
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

        [Route("Products/Catalog")]
        [Route("Products/Catalog/{category}")]
        public ViewResult Catalog(string category)
        {

            string _category = category;
            IEnumerable<Product> prods = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category)) {
                prods = _allProducts.AllProducts.OrderBy(i => i.id);
            }
            else{
                if (string.Equals("ring", category, StringComparison.OrdinalIgnoreCase))
                {
                    prods = _allProducts.AllProducts.Where(i => i.Category.categoryName.Equals("Кольца"));
                }
                else if (string.Equals("earing", category, StringComparison.OrdinalIgnoreCase)){
                    prods = _allProducts.AllProducts.Where(i => i.Category.categoryName.Equals("Серьги"));
                }

                else if (string.Equals("necklace", category, StringComparison.OrdinalIgnoreCase)) {
                    prods = _allProducts.AllProducts.Where(i => i.Category.categoryName.Equals("Ожерелья"));
                }
                else if (string.Equals("bracelet", category, StringComparison.OrdinalIgnoreCase)) {
                    prods = _allProducts.AllProducts.Where(i => i.Category.categoryName.Equals("Браслеты"));
                }

                currCategory = _category;
            }

            var prodObj = new ProductCatalogViewModel
            {
                AllProducts = prods,
                currCategory = currCategory
            };
    ViewBag.Title = "Jewelery catalog";
           
            return View(prodObj);
        }
    }
}
