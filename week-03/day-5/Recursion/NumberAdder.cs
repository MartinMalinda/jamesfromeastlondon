using System;

namespace Recursion
{
    public class NumberAdderTask
    {
        public static void Main(string[] args)
        {
            //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.

            uint n = Convert.ToUInt32(Console.ReadLine());
            
            Console.WriteLine(NumberAdder(n));
        }
        public static uint NumberAdder(uint n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + NumberAdder(n - 1);
        }
    }
}
