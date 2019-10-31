using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    
    public class UsefulController : Controller
    {
        private UtilityService utilityService;

        public UsefulController(UtilityService utilityService)
        {
            this.utilityService = utilityService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Colored")]
        public IActionResult Colored()
        {
            ViewData["color"] = utilityService.RandomColor();
            return View();
        }

        [Route("/Email")]
        public IActionResult Email(string email)
        {
            ViewData["bool"] = utilityService.ValidateEmail(email);
            ViewData["email"] = email;
            return View();
        }
    }
}
