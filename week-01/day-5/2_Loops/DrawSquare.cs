using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was
            Console.WriteLine("How many lines tall will your square be?");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= number;  col++)
                {
                    if (row == 1 || row == number ||
                        col == 1 || col == number)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
