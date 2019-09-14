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
            int userInput = Convert.ToInt32(Console.ReadLine());

            int topRow = 0;
            while (topRow < userInput)
            {
                Console.Write("%");
                topRow ++;
            }
            Console.WriteLine();
                
            int middleRowCount = 0;
            string middleRow = "%".PadRight(userInput-1);

            while (middleRowCount < userInput-2)
            {
                Console.Write(middleRow);
                Console.WriteLine("%");
                middleRowCount ++;
            }

            int bottomRow = 0;
            while (bottomRow < userInput)
            {
                Console.Write("%");
                bottomRow++;
            }

        }
    }
}