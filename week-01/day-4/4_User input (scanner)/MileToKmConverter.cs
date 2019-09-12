using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it

            Console.Write("How many miles did you run today? ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometers = miles * 1.60934;

            Console.WriteLine($"That is {kilometers} km");
        }
    }
}