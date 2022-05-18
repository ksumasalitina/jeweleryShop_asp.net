using System;
using jeweleryShop.Data.Interfaces;
using jeweleryShop.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeweleryShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;
        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }
        
        [Route("Order/Checkout")]
        public IActionResult Checkout(Order order)
        {
            shopCart.cartItems = shopCart.getCartItems();
            if (shopCart.cartItems.Count == 0)
            {
                ModelState.AddModelError("", "Ви повинні додати товар!");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Замовлення відправлено на обробку!";
            return View();
        }

    }
}
