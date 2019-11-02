using System;
using HelloWorld.Interfaces;

namespace HelloWorld.Models
{
    public class Red : IColor
    {
        private Printer printer;

        public Red(Printer printer)
        {
            this.printer = printer;
        }

        public void PrintColor()
        {
            printer.Log("It is red in color");
        }
    }
}
