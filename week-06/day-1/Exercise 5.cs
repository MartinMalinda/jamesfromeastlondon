using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var numFrequencyA = n.GroupBy(num => num).ToList();
            numFrequencyA.ForEach(num => Console.WriteLine($"{num.Key} appears {num.Count()} time(s)"));

            var numFrequencyB = from number in n
                                   group number by number into g
                                   select new { g.Key, Count = g.Count() };

            foreach (var number in numFrequencyB)
            {
                Console.WriteLine($"{number.Key} appears {number.Count} time(s)");
            }
        }
    }
}
