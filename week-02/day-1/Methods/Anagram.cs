using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a function named is anagram following your current language's style guide.
            //It should take two strings and return a boolean value depending on whether its an anagram or not.

            //Examples

            //input 1   input 2     output
            //"dog"     "god"       true
            //"green"   "fox"       false

            Console.WriteLine("Please enter your first string: ");
            string strOne = Console.ReadLine();

            Console.WriteLine("Please enter your second string: ");
            string strTwo = Console.ReadLine();

            Console.WriteLine(AnagramCheck(strOne, strTwo));
        }

        public static bool AnagramCheck(string strOne, string strTwo)
        {
            bool isAnagram = true;

            if (strOne.Length != strTwo.Length)
            {
                isAnagram = false;
            }
            else
            {
                char[] arrOne = strOne.ToLower().ToCharArray();
                char[] arrTwo = strTwo.ToLower().ToCharArray();

                Array.Sort(arrOne);
                Array.Sort(arrTwo);

                string strArrOne = new string(arrOne);
                string strArrTwo = new string(arrTwo);

                if (strArrOne == strArrTwo)
                {
                    isAnagram = true;
                }
                else
                {
                    isAnagram = false;
                }
            }
            return isAnagram;
        }
    }
}
