using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class PersonalFinance
    {
        public static void Main(string[] args)
        {
            List<int> expenses = new List<int>();
            expenses.AddRange(new int[] { 500, 1000, 1250, 175, 800, 120 });

            int sum = 0;
            for (int i = 0; i < expenses.Count; i++)
            {
                sum += expenses[i];
            }
            Console.WriteLine("This is how much we spent: " + sum);

            expenses.Sort();
            Console.WriteLine("The greatest expense: " + expenses[expenses.Count - 1]);
            Console.WriteLine("The cheapest expense: " + expenses[0]);

            int average = sum / expenses.Count;
            Console.WriteLine("The average expense: " + average);
        }
    }
}