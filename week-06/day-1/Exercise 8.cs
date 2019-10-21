using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string.
            string str = "Blahbla Hello";

            var uppercaseFinderA = str.Where(c => char.IsUpper(c)).ToList();
            uppercaseFinderA.ForEach(Console.WriteLine);

            var uppercaseFinderB = from character in str
                                  where char.IsUpper(character)
                                  select character;
            foreach (var character in uppercaseFinderB)
            {
                Console.WriteLine(character);
            }
        }
    }
}
