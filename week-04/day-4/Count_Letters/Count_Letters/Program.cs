using System;
using System.Collections.Generic;

namespace Count_Letters
{
    public class CountingLetters
    {
        public Dictionary<char, int> StringToDictionary(string str)
        {
            var letterCounts = new Dictionary<char, int>();
            foreach (char character in str)
            {
                if (letterCounts.ContainsKey(character))
                {
                    letterCounts[character]++;
                }
                else
                {
                    letterCounts[character] = 1;
                }
            }
            return letterCounts;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
        }
    }
}

//Write a function, that takes a string as an argument and returns a dictionary with all letters
//in the string as keys, and numbers as values that shows how many occurrences there are.
//Create a test for that.