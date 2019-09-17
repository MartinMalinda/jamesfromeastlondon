using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ListIntroduction1
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("William");
            names.Add("John");
            names.Add("Amanda");

            Console.WriteLine(names.Count); // Print out the number of elements in the list
            Console.WriteLine(names[2]); // Print out the 3rd element


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Iterate through the list and print out names with number positions
            int namePosition = 0;
            for (int i = 0; i < names.Count; i++)
            {
                namePosition ++;
                Console.WriteLine(namePosition + ". " + names[i]);
            }

            Console.WriteLine("\nRemoved the second name (John)");
            names.RemoveAt(1);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Count);

            Console.WriteLine("\nIterate through the list in a reversed order, and print out each name");
            for (int i = names.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("\nRemove all elements");
            names.RemoveRange(0, names.Count);
            Console.WriteLine(names.Count);
        }
    }
}