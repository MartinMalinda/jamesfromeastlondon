using System;
using System.Collections;
using System.Linq;

namespace Anagram
{
    public class Anagrammy
    {
        public bool AnagramChecker(string strA, string strB)
        {
            if (strA.Length != strB.Length)
            {
                return false;
            }

            char[] sortA = strA.ToCharArray();
            char[] sortB = strB.ToCharArray();

            Array.Sort(sortA);
            Array.Sort(sortB);

            for (int i = 0; i < strA.Length; i++)
            {
                if (sortA[i] != sortB[i])
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

//Write a function, that takes two strings and returns a boolean value
//based on if the two strings are Anagramms or not.
//Create a test for that.