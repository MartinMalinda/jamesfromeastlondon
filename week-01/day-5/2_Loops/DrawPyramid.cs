using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How tall will your pyramid be?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int spaceMax = userInput;
            int starMax = userInput;

            for (int row = 0; row < userInput; row++)
            {
                for (int i = 0; i < spaceMax; i++)
                {
                    Console.Write(" ");
                }
                spaceMax--;
                for (int j = userInput - 1; j < starMax; j++)
                {
                    Console.Write("*");
                }
                starMax += 2;
                Console.WriteLine();
            }
        }
    }
}

//   *
//  ***
// *****
//*******