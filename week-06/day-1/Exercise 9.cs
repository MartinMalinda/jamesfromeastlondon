using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string.
            char[] charArr = { 'H', 'e', 'l', 'l', 'o' };

            var convertToStringA = string.Join("", charArr.Select(c => c));
            Console.Write(convertToStringA);

            //Array.ForEach(charArr, Console.Write);
        }
    }
}
