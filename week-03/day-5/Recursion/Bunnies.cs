using System;

namespace Recursion
{
    public class BunniesTask
    {
        public static void Main(string[] args)
        {
            //We have a number of bunnies and each bunny has two big floppy ears.
            //We want to compute the total number of ears across all the bunnies recursively(without loops or multiplication).

            Console.WriteLine("How many bunnies?");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Bunnies(num));
        }
        public static int Bunnies(int num)
        {
            if (num == 1)
            {
                return 2;
            }
            return 2 + Bunnies(num - 1);
        }
    }
}
