using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        static List<BankAccount> accountDetails = new List<BankAccount>()
        {
            new BankAccount ( "Simba", 50.00m, "Lion", false ),
            new BankAccount ( "Mufasa", 100.00m, "Lion", true),
            new BankAccount ( "Timon", 10.00m, "Meerkat", false),
            new BankAccount ("Pumba", 12.50m, "Warthog", false),
            new BankAccount ("Ed", 4.00m, "Hyena", false),
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
            //ViewData["Message"] = "Your application description page.";
            return View(accountDetails);
        }

        public IActionResult HTMLCeption ()
        {
            return View();
        }

        public IActionResult RaiseBalance ()
        {
            foreach (var account in accountDetails)
            {
                decimal raiseValue = 10.00m;
                if (account.IsKing)
                {
                    raiseValue = 100.00m;
                } 
                account.Balance += raiseValue;
            }
            return RedirectToAction("Show");
        }

        public IActionResult AddAccount (string name, string animalType, bool isKing)
        {
            BankAccount NewAccount = new BankAccount(name, 0.00m, animalType, isKing);
            accountDetails.Add(NewAccount);
            return RedirectToAction("Show");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
