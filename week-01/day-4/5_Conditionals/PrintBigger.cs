using System;
namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is bigger");
            }
            else if (num2 > num1)
            {
                Console.WriteLine(num2 + " is bigger");
            }
            else
            {
                Console.WriteLine("The numbers are the same");
            }
        }
    }
}