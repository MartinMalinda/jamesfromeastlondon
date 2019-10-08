using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array
            //Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            //Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'
            
            int[] arrayToCheckOne = SubInt(1, new int[] { 1, 11, 34, 52, 61 });

            Console.Write("[");
            foreach (var num in arrayToCheckOne)
            {
                Console.Write(num + " ");
            }
            Console.Write("]");
        }

        public static int[] SubInt (int num, int[] arr)
        {
            int[] subIntArr = new int[arr.Length];
            int subIntArrSize = 0;
            int counterIndex = 0;
            string numString = num.ToString();

            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i].ToString()).Contains(numString))
                {
                    subIntArr[counterIndex] = i;
                    counterIndex++;
                    subIntArrSize = counterIndex;
                }
            }

            int[] subIntArrResized = new int[subIntArrSize];
            for (int i = 0; i < subIntArrSize; i++)
            {
                subIntArrResized[i] = subIntArr[i];
            }

            return subIntArrResized;
        }
    }
}
