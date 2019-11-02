using System;
namespace HelloWorld.Models
{
    public class Printer
    {
        public void Log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);
        }

        public Printer()
        {
        }
    }
}
