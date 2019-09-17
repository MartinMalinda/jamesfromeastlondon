using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ListIntroduction2
    {
        public static void Main(string[] args)
        {
            List<string> ListA = new List<string>();
            ListA.Add("Apple");
            ListA.Add("Avocado");
            ListA.Add("Blueberries");
            ListA.Add("Durian");
            ListA.Add("Lychee");

            List<string> ListB = new List<string>();
            ListB.AddRange(ListA);

            if (ListA.Contains("Durian"))
            {
                Console.WriteLine("List A contains Durian.");
            }
            else
            {
                Console.WriteLine("List A does not contain Durian");
            }

            ListB.Remove("Durian");
            ListA.Insert(4, "Kiwifruit");

            foreach (var item in ListA)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nList A has {0} items, whereas List B has {1} items", ListA.Count, ListB.Count);

            int indexA = ListA.FindIndex(a => a.Contains("Avocado"));
            Console.WriteLine("\nList A contains Avocado in index: " + indexA);

            int indexB = ListB.FindIndex(a => a.Contains("Durian"));
            Console.WriteLine("\nList B contains Durian in index: " + indexB);

            //Add Passion Fruit and Pomelo to List B in a single statement
            ListB.AddRange(new string[] { "Passion Fruit", "Pomelo" });

            Console.WriteLine(ListA[2]);
        }
    }
}