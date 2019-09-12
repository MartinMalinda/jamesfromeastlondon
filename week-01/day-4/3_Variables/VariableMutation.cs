using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            a += 10;
            // make it bigger by 10

            Console.WriteLine(a);

            int b = 100;
            b -= 7;
            // make it smaller by 7

            Console.WriteLine(b);

            int c = 44;
            c *= 2;
            // please double c's value

            Console.WriteLine(c);

            int d = 125;
            d /= 5;
            // please divide by 5 d's value

            Console.WriteLine(d);

            int e = 8;
            e *= e * e;
            // please cube of e's value

            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            bool f1BiggerThanF2 = f1 > f2;
            // tell if f1 is bigger than f2 (print as a boolean)

            Console.WriteLine(f1BiggerThanF2);

            int g1 = 350;
            int g2 = 200;
            bool doubleG2BiggerThanG1 = (g2 * 2) > g1;
            // tell if the double of g2 is bigger than g1 (print as a boolean)

            Console.WriteLine(doubleG2BiggerThanG1);

            long h = 1357988018575474;
            bool is11DivisorOfH = (h % 11) == 0;
            // tell if 11 is a divisor of h (print as a boolean)

            Console.WriteLine($"Is 11 a divisor of h? {is11DivisorOfH}");

            int i1 = 10;
            int i2 = 3;
            bool isI1GreaterI2Squared = i1 > (i2 * i2);
            bool isI1SmallerThanI2Cubed = i1 < (i2 * i2 * i2);
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            Console.WriteLine("Is i1 greater than i2 squared? " + isI1GreaterI2Squared);
            Console.WriteLine("Is i1 smaller than i2 cubed? " + isI1SmallerThanI2Cubed);

            int j = 1521;
            bool isJDivisibleBy3 = (j % 3) == 0;
            bool isJDivisibleBy5 = (j % 5) == 0;
            // tell if j is divisible by 3 or 5 (print as a boolean)

            Console.WriteLine($"Is j divisible by 3? {isJDivisibleBy3}");
            Console.WriteLine($"Is j divisible by 5? {isJDivisibleBy5}");
        }
    }
}