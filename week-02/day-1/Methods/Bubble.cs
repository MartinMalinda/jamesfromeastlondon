using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as parameter
            //  Returns a list where the elements are sorted in ascending numerical order
            //  Make a second boolean parameter, if it's `true` sort that list descending

            foreach (var item in Bubble(new int[] { 34, 12, 24, 9, 5 }))
            {
                Console.Write(item + " ");
            }
            //  should print [5, 9, 12, 24, 34]

            Console.WriteLine();
            foreach (var item in AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true))
            {
                Console.Write(item + " ");
            }
            //  should print [34, 24, 12, 9, 5]
        }

        public static int[] Bubble(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        public static int[] AdvancedBubble(int [] arr, bool isTrue)
        {
            Array.Sort(arr);
            if (isTrue)
            {
                Array.Reverse(arr);
            }
            return arr;
        }
    }
}
