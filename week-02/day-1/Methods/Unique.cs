using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a method that takes an array of integers as a parameter
            //  Returns an array of integers where every integer occurs only once

            //  Example
            //Console.WriteLine(Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
            //  should print: `[1, 11, 34, 52, 61]`

            foreach (var item in Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }))
            {
                Console.Write(item + " ");
            }
        }

        public static int[] Unique(int[] inputArr)
        {
            int[] outputArr = new int[inputArr.Length];
            int arrResized = 0;
            bool isUnique = true;

            for (int a = 0; a < inputArr.Length; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    if (inputArr[a] == inputArr[b])
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    outputArr[arrResized] = inputArr[a];
                    arrResized++;
                }
                isUnique = true;
            }

            int[] uniqueArr = new int[arrResized];
            for (int i = 0; i < arrResized; i++)
            {
                uniqueArr[i] = outputArr[i];
            }

            return uniqueArr;
        }
    }
}
