using System;
using System.Threading.Tasks;
using HelloWorld.Interfaces;
using Microsoft.AspNetCore.Http;

namespace HelloWorld.Models
{
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        private Printer printer;
        private IColor color;

        public ConsoleLoggerMiddleware(Printer printer, IColor color)
        {
            this.printer = printer;
            this.color = color;
        }

        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            printer.Log("hello");
            color.PrintColor();
            return next(context);
        }
    }
}
