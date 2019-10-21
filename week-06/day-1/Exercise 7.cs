using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var filterCitiesA = cities.Where(c => c[0] == 'A' && c[c.Length - 1] == 'I').ToList();
            filterCitiesA.ForEach(Console.WriteLine);

            var filterCitiesB = from city in cities
                               where city[0] == 'A' && city[city.Length - 1] == 'I'
                               select city;

            foreach (var city in filterCitiesB)
            {
                Console.WriteLine(city);
            }
        }
    }
}
