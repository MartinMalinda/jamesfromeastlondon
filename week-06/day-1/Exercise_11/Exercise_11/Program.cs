using System;
using System.IO;
using System.Linq;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a single LINQ expression which reads all text from this file,
            //and prints the 100 most common words in descending order.
            //Keep in mind that the text contains punctuation characters which should be ignored.
            var file = File.ReadAllText(@"./wiki_roulette.txt");
            char[] separators = { ' ', '\n', '\r', ',', '.', '(', ')', '[', ']' };
            var splitFile = file.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var fileWordCount = splitFile.GroupBy(f => f).ToList();
            fileWordCount.ForEach(word => Console.WriteLine(word.Key + ": " + word.Count()));
        }
    }
}
