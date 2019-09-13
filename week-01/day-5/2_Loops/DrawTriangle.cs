using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            Console.WriteLine("How many lines tall will your triangle be? ");
            int number = Convert.ToInt32(Console.ReadLine());

            string starZero = "";
            string starOne = "*";
            int printedStar = 0;

            while (printedStar < number)
            {
                Console.WriteLine(starZero += starOne);
                printedStar += 1;
            }
        }
    }
}