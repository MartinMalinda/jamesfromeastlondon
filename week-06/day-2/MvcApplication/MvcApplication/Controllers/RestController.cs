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

        [Route("greeting")]
        [HttpGet]
        public Greeting greeting()
        {
            Greeting greet = new Greeting(1, "Hello, World!");
            return greet;
        }
    }
}
