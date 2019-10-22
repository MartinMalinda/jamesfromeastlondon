using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcApplication.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        static long counter;
        [Route("greeting")]
        [HttpGet]
        public Greeting Greeting(string name)
        {
            Greeting greet = new Greeting(counter++, $"Hello, {name}!");
            return greet;
        }
    }
}
