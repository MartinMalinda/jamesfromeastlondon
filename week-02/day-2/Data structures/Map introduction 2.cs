using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class MapIntroduction2
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> diction = new Dictionary<string, string>();
            diction.Add("978-1-60309-452-8", "A Letter to Jo");
            diction.Add("978-1-60309-459-7", "Lupus");
            diction.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            diction.Add("978-1-60309-461-0", "The Lab");

            foreach (var pair in diction)
            {
                Console.WriteLine("{0} (ISBN: {1})", pair.Value, pair.Key);
            }

            // Remove the key-value pair with key 978-1-60309-444-3
            diction.Remove("978-1-60309-444-3");

            // Remove the key-value pair with value The Lab
            foreach (var item in diction.Where(kvp => kvp.Value == "The Lab").ToList())
            {
                diction.Remove(item.Key);
            }

            Console.WriteLine("\nUpdated list with items removed:");

            foreach (var pair in diction)
            {
                Console.WriteLine("{0} (ISBN: {1})", pair.Value, pair.Key);
            }

            // Added 2 key-value pairs
            diction.Add("978-1-60309-450-4", "They Called Us Enemy");
            diction.Add("978-1-60309-453-5", "Why Did We Trust Him?");
            
            // Check for a key-value pair
            string getValue = "";
            if (diction.TryGetValue("478-0-61159-424-8", out getValue))
            {
                Console.WriteLine("\nKey: 478-0-61159-424-8 contains {0}", getValue);
            }
            else
            {
                Console.WriteLine("\nKey: 478-0-61159-424-8 cannot be found.");
            }

            // Print an key-value pair
            Console.WriteLine(diction["978-1-60309-453-5"]);
        }
    }
}