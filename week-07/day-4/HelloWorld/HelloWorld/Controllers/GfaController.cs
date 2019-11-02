using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    public class GfaController : Controller
    {
        private StudentService studentService;

        public GfaController (StudentService studentService)
        {
            this.studentService = studentService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var names = studentService.FindAll();
            ViewData["count"] = studentService.Count();
            return View(names);
        }

        public IActionResult List()
        {
            var names = studentService.FindAll();
            return View(names);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Save(string name)
        {
            studentService.Save(name);
            return View();
        }

        public IActionResult Check(string checkname)
        {
            ViewData["query"] = checkname + studentService.Check(checkname);
            return View();
        }
    }
}
