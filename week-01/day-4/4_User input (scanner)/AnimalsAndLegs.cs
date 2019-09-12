using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            int chickensLegs = 2;
            int pigsLegs = 4;

            Console.Write("How many chickens do you have? ");
            int chickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("That's a total of {0} legs", chickens * chickensLegs);

            Console.Write("How many pigs do you have? ");
            int pigs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("That's a total of {0} legs", pigs * pigsLegs);
        }
    }
}