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
            new BankAccount ( "Simba", 50.00m, "Lion" )
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
