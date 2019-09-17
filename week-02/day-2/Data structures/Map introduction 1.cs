using System;
using System.Collections.Generic;
using System.Text;

namespace Map
{
    public class MapIntroduction1
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> diction = new Dictionary<int, string>();

            bool isEmpty = (diction.Count == 0);
            if (isEmpty)
            {
                Console.WriteLine("The dictionary is empty");
            }

            diction.Add(97, "a");
            diction.Add(98, "b");
            diction.Add(99, "c");
            diction.Add(65, "A");
            diction.Add(66, "B");
            diction.Add(67, "C");

            Console.WriteLine("\nThis prints all the keys");
            Dictionary<int, string>.KeyCollection
            keyColl = diction.Keys;

            foreach (var key in keyColl)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\nThis prints all the values");
            Dictionary<int, string>.ValueCollection
            valueColl = diction.Values;

            foreach (var value in valueColl)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();
            diction.Add(68, "D");
            Console.WriteLine("There are " + diction.Count + " key-value pairs\n");

            Console.WriteLine("This is the value that is associated with key 99:");
            Console.WriteLine(diction[99]);

            diction.Remove(97);

            string getValue = "";
            if (diction.TryGetValue(100, out getValue))
            {
                Console.WriteLine("\nFor key = \"100\", value = {0}.", getValue);
            }
            else
            {
                Console.WriteLine("\nKey = \"100\" cannot be found.");
            }

            diction.Clear();
            bool isEmpty2 = (diction.Count == 0);
            if (isEmpty2)
            {
                Console.WriteLine("\nThe dictionary is empty");
            }
        }
    }
}