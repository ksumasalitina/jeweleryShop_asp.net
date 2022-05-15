using System;
namespace jeweleryShop.Data.Models
{
    public class Product
    {
        public int id { set; get; }

        public string name { set; get; }

        public string description { set; get; }

        public string img { set; get; }

        public ushort price { set; get; }

        public bool isPopular { set; get; }

        public bool available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
