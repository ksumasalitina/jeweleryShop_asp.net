using System;
using jeweleryShop.Data.Models;

namespace jeweleryShop.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
