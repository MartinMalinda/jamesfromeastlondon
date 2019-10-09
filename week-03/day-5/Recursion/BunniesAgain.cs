using System;

namespace Recursion
{
    public class BunniesTask
    {
        public static void Main(string[] args)
        {
            //We have bunnies standing in a line, numbered 1, 2, ...
            //The odd bunnies(1, 3, ..) have the normal 2 ears.
            //The even bunnies(2, 4, ..) we'll say have 3 ears, because they each have a raised foot.
            //Recursively return the number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

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
            if (num % 2 == 0)
            {
                return 3 + Bunnies(num - 1);
            }
            return 2 + Bunnies(num - 1);
        }
    }
}
