using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = { 3, 4, 5, 6, 7 };

            for (int row = 4; row >= 0; row--) // Start: 4, End: 0 
            {
                Console.WriteLine(aj[row]);
            }

            Console.ReadLine();
        }
    }
}