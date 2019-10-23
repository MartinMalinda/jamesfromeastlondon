using System;
namespace WebShop.Models
{
    public class ShopItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int QuanitityOfStock { get; set; }

        public ShopItem()
        {
        }
    }
}
