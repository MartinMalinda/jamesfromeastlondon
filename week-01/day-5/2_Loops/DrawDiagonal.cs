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
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
            Console.WriteLine("How many lines tall will your square (with diagonal) be?");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            {
                int row, column;
                for (row = 1; row <= userNumber; row ++)
                {
                    for (column = 1; column <= userNumber; column++)
                    {
                        if (row == 1 || row == userNumber || // top row, bottom row
                            column == 1 || column == userNumber || // start column, end column
                            row == column) // diagonal
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}