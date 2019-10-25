using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebShop.Controllers
{
    public class ShopController : Controller
    {
        static List<ShopItem> ShopItemList = new List<ShopItem>() {
            new ShopItem("Nike Air Sandals", "Enhanced with built-in socks", 1000, 5),
            new ShopItem("Poppy Seed Juice", "300ml carton (bamboo straw included)", 30, 20),
            new ShopItem("Bento Box", "A bit of rice and sashimi", 150, 1),
            new ShopItem("Vintage Pencil", "Graphite pencil (bite marks included)", 10, 5),
            new ShopItem("Paper plane", "Engineered from cross-laminated toilet paper", 40, 0)
        };

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(ShopItemList);
        }

        public IActionResult OnlyAvailable()
        {
            var AvailableList = ShopItemList.Where(s => s.QuantityOfStock > 0).ToList();
            return View(AvailableList);
        }

        public IActionResult CheapestFirst()
        {
            var CheapestFirstList = ShopItemList.OrderBy(s => s.Price).ToList();
            return View(CheapestFirstList);
        }

        public IActionResult ContainsNike()
        {
            var ContainsNikeList = ShopItemList.Where(s => s.Name.Contains("Nike")).ToList();
            return View(ContainsNikeList);
        }

        public IActionResult AverageStock()
        {
            var AverageStockList = ShopItemList.Select(s => s.QuantityOfStock).ToList();
            ViewData["avgStock"] = AverageStockList.Average().ToString();
            return View();
        }

        public IActionResult MostExpensiveAvailable()
        {
            var MostExpensiveAvailableItem = ShopItemList.Where(s => s.QuantityOfStock > 0).OrderByDescending(s => s.Price).First();
            ViewData["expensiveAvailable"] = MostExpensiveAvailableItem.Name;
            return View();
        }
    }
}
