using System;
namespace jeweleryShop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int productID { get; set; }
        public uint price { get; set; }
        public virtual Product products { get; set; }
        public virtual Order order { get; set; }
    }
}
