using System;
namespace GreenFox
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please provide the first number:");
            // Get the first number:
            // int number1 = ...
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the second number:");
            // Get the second number:
            // int number2 = ...
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");
            // Get the operation from standard input:
            // string operation = ...
            // use the `switch` statement and the corresponding calculation
            // store the result of the calculation in the `result` variable
            string operation = Console.ReadLine();
            double result = 0.0;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                case "x":
                    result = number1 * number2;
                    break;
                case "/":
                    result = Convert.ToDouble(number1 - number2);
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }

            Console.WriteLine($"The result of the calculation is {result}");
        }
    }
}