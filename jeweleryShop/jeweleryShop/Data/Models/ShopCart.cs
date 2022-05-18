using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace jeweleryShop.Data.Models
{
    public class ShopCart
    {
        private AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string cartId { get; set; }

        public List<CartItem> cartItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartID") ?? Guid.NewGuid().ToString();

            session.SetString("CartID", shopCartId);

            return new ShopCart(context) { cartId = shopCartId };
        }

        public void AddToCart(Product product) {
            appDBContent.CartItem.Add(new CartItem
            {
                cartId = cartId,
                product = product,
                productid = product.id,
                price = product.price,
            });

            appDBContent.SaveChanges();
        }

        public List<CartItem> getCartItems()
        {
            return appDBContent.CartItem.Where(x => x.cartId == cartId).Include(s => s.product).ToList();
        }
    }
}
