using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //

            for (int row = 0; row < 8; row ++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine("% % % %");
                }
                else
                {
                    Console.WriteLine(" % % % %");
                }
            }
        }
    }
}