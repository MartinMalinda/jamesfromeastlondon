using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var squareNumberA = n.Where(num => Math.Pow(num, 2) > 20);

            var squareNumberB =
                from number in n
                where Math.Pow(number, 2) > 20
                select number;

            foreach (var number in squareNumberA)
            {
                Console.WriteLine(number);
            }
        }
    }
}
