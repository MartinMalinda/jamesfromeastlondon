using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the even numbers from the following array:
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbersA = n.Where(num => num % 2 == 0);

            var evenNumbersB =
                from number in n
                where number % 2 == 0
                select number;

            evenNumbersA.ToList().ForEach(Console.WriteLine);
        }
    }
}
