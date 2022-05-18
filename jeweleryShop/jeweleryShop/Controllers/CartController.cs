using System;
using System.Linq;
using jeweleryShop.Data.Interfaces;
using jeweleryShop.Data.Models;
using jeweleryShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace jeweleryShop.Controllers
{
    public class CartController : Controller
    {
        private readonly IProducts _prodRep;
        private readonly ShopCart _shopCart;

        public CartController(IProducts prodRep, ShopCart shopCart)
        {
            _prodRep = prodRep;
            _shopCart = shopCart;
        }

        [Route("Cart/Index")]
        public ViewResult Index()
        {
            var items = _shopCart.getCartItems();
            _shopCart.cartItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _prodRep.AllProducts.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
