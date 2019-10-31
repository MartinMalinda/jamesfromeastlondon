using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HelloWorld.Models
{
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        private Printer printer;

        public ConsoleLoggerMiddleware(Printer printer)
        {
            this.printer = printer;
        }

        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            printer.Log("hello");
            return next(context);
        }
    }
}
