using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxClub.Controllers
{

    public class HomeController : Controller
    {
        private FoxService foxService;

        public HomeController(FoxService foxService)
        {
            this.foxService = foxService;
        }

        // GET: /<controller>/
        [Route("")]
        public IActionResult Index(string name)
        {
            ViewData["name"] = name;
            return View();
        }

        [HttpGet]
        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("/Login")]
        public IActionResult Login(string name)
        {
            foxService.AddFox(name);
            return RedirectToAction ("Index", new { name = name });
        }
    }
}
