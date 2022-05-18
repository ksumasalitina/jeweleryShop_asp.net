using System;
using jeweleryShop.Data.Interfaces;
using jeweleryShop.Data.Models;

namespace jeweleryShop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();
            var items = shopCart.cartItems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    productID = el.product.id,
                    orderID = order.id,
                    price = el.product.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
    appDBContent.SaveChanges();
        }

    }
}
