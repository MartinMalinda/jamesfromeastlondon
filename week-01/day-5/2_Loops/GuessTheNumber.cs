using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int correctNumber = 8;
            int userNumber;

            do
            {
                Console.Write("Guess the number: ");
                userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber < correctNumber)
                {
                    Console.WriteLine("The stored number is higher");
                }
                else if (userNumber > correctNumber)
                {
                    Console.WriteLine("The stored number is lower");
                }
                else
                {
                    Console.WriteLine($"You found the number: {correctNumber}");
                }
            } while (userNumber != correctNumber);
        }
    }
}