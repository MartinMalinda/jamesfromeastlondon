using System;
using System.IO;

namespace FileManipulations
{
    public class DivideByZeroTask
    {
        // Create a function that takes a number
        // divides ten with it,
        // and prints the result.
        // It should print "fail" if the parameter is 0

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int divisor = 0;
            try
            {
                divisor = int.Parse(Console.ReadLine());
                Console.WriteLine(10/divisor);
            }
            catch (DivideByZeroException e)
            {
                Console.Error.WriteLine(e);
                Console.WriteLine("You cannot input zero!");
            }
        }
    }
}
