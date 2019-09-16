using System;

namespace Factorio
{
    class Program
    {
        public static void Factorio (int user)
        {
            int factorial = 1;
            for (int i = 1; i <= user; i++)
            {
                factorial *= i; 
            }
            Console.WriteLine(factorial);
        }

        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial
            Console.WriteLine("Please enter a number to discover its factorial value:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Factorio(userInput);
        }
    }
}