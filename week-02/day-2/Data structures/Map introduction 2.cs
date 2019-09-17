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
        }
    }
}