using System;

namespace Recursion
{
    public class GreatestCommonDivisorTask
    {
        public static void Main(string[] args)
        {
            //Find the greatest common divisor of two numbers using recursion

            Console.WriteLine("First number to compare: ");
            int aNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number to compare: ");
            int bNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GreatestDivisor(aNum, bNum));
        }
        public static int GreatestDivisor(int aNum, int bNum)
        {
            if (aNum == bNum)
            {
                return aNum;
            }
            if (aNum > bNum)
            {
                return aNum - bNum;
            }
            if (bNum > aNum)
            {
                return bNum - aNum;
            }
            return GreatestDivisor(aNum, bNum);
        }
    }
}
