using System;

namespace Recursion
{
    public class SumDigitsTask
    {
        public static void Main(string[] args)
        {
            // Given a non-negative integer n, return the sum of its digits recursively(without loops).
            // Divide(/) by 10 removes the rightmost digit(e.g. 126 / 10 is 12).

            uint n = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine(SumDigits(n));
        }
        public static uint SumDigits(uint n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n % 10 + SumDigits(n / 10);
        }
    }
}
