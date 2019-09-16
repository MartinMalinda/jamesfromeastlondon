using System;

namespace Sum
{
    class Program
    {
        public static void Sum (int user)
        {
            int sumMethod = 0;
            for (int i = 0; i <= user; i++)
            {
                sumMethod += i;
            }
            Console.WriteLine(sumMethod);
        }

        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter

            Console.WriteLine("This program will calculate a sum from 0 to your number input:");

            int userInput = Convert.ToInt32(Console.ReadLine());
            Sum(userInput);
        }
    }
}