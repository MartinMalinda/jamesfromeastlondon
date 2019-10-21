using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string.
            string str = "thisstring";

            var charFrequencyA = str.GroupBy(c => c).ToList();
            charFrequencyA.ForEach(c => Console.WriteLine($"{c.Key} appears {c.Count()} time(s)"));

            var charFrequencyB = from character in str
                                     group character by character into g
                                     select new { Value = g.Key, Count = g.Count() };
            foreach (var character in charFrequencyB)
            {
                Console.WriteLine($"{character.Value} appears {character.Count} time(s)");
            }
        }
    }
}
