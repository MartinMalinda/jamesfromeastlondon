using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcApplication.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [HttpGet("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greeting()
            {
                Id = 1,
                Content = "from the model"
            };

            return View(greeting);
        }
    }
}
