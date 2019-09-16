using System;

namespace AppendAFunc
{
    class Program
    {
        public static void AppendAFunc (string start)
        {
            string end = "a";
            Console.WriteLine(start + end);
        }

        static void Main(string[] args)
        {
            // - Create a string variable named `typo` and assign the value `Chinchill` to it
            // - Write a function called `AppendAFunc` that gets a string as an input,
            //   appends an 'a' character to its end and returns with a string
            // - Print the result of `AppendAFunc(typo)`

            string typo = "Chinchill";
            AppendAFunc(typo);

            Console.ReadLine();
        }
    }
}