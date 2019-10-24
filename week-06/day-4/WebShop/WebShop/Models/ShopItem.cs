using System;
using System.Collections.Generic;

namespace WebShop.Models
{
    public class ShopItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int QuantityOfStock { get; set; }

        public ShopItem(string name, string description, int price, int quantityOfStock )
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityOfStock = quantityOfStock;
        }

        public ShopItem()
        {
        }
    }
}
