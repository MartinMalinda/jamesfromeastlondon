using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a function named create palindrome following your current language's style guide.
            //It should take a string, create a palindrome from it and then return it.

            //Examples

            //input         output
            //""            ""
            //"greenfox"    "greenfoxxofneerg"
            //"123"         "123321"

            Console.WriteLine("Enter a word to generate a palindrome:");
            string word = Console.ReadLine();

            Console.Write(word);
            Console.Write(PalindromeBuilder(word));
        }

        public static string PalindromeBuilder (string word)
        {
            char[] arrWord = word.ToCharArray();
            char[] arrNewWord = new char[10];
            int counter = 0;

            for (int a = arrWord.Length - 1; a >= 0; a--)
            {
                arrNewWord[counter] = arrWord[a];
                counter++;
            }
            string palindrome = new string (arrNewWord);
            return palindrome;   
        }
    }
}
