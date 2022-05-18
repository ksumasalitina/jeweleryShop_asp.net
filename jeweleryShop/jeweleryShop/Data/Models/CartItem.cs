using System;
namespace jeweleryShop.Data.Models
{
    public class CartItem
    {
        public int id { get; set; }

        public Product product { get; set; }

        public int productid { get; set; }

        public int price { get; set; }

        public string cartId { get; set; }

    }
}
