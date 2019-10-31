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
        private UtilityService utilityServices;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Colored(UtilityService utilityService)
        {
            ViewData["color"] = utilityService.RandomColor();
            return View();
        }
    }
}
