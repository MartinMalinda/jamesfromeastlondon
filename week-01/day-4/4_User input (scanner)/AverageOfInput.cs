using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.Write("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4 + num5;
            double average = sum / 5;

            Console.WriteLine("Sum: {0}, Average: {1}", sum, average);
        }
    }
}