using System;

namespace Recursion
{
    public class PowerTask
    {
        public static void Main(string[] args)
        {
            //Given base and n that are both 1 or more, compute recursively(no loops) the value of base to the n power,
            //so powerN(3, 2) is 9(3 squared).

            Console.WriteLine("Enter a base number: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a power number: ");
            int powerNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Power(baseNum, powerNum));
        }
        public static int Power(int baseNum, int powerNum)
        {
            if (powerNum == 0)
            {
                return 1;
            }
            return baseNum * Power(baseNum, powerNum - 1);
        }
    }
}
