using System;
using HelloWorld.Interfaces;

namespace HelloWorld.Models
{
    public class Blue : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("It is blue in color");
        }
    }
}
