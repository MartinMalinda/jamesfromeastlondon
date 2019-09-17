using System;

namespace Reverse
{
    public class ReverseProgram
    {
        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray );
            return new string (charArray);
        }
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(reversed));
        }
    }
}