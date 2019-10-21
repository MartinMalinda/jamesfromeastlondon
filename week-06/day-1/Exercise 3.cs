using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var positiveNumbersA = n.Where(num => num > 0);

            var positiveNumbersB =
                from number in n
                where number > 0
                select number;

            foreach (var number in positiveNumbersB)
            {
                Console.WriteLine(Math.Pow(number, 2));
            }
        }
    }
}
