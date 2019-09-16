using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            int[,] twoDimensional =
            {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 },
            };

            for (int row = 0; row < twoDimensional.GetLength(0); row++)
            {
                for (int column = 0; column < twoDimensional.GetLength(1); column++)
                {
                    Console.Write(twoDimensional[row,column] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}