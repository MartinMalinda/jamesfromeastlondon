using System;
using System.Collections.Generic;
using System.Linq;

namespace GreenFox
{
    public class Fox
    {
        //Create a Fox class with 3 properties: name, type and color.
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Fox(string name)
        {
            Name = name;
            Type = "pallida";
            Color = "orange";

        }
        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Fill a list with at least 5 foxes, it's up to you how you name/create them.
            //Write a LINQ Expression to find the foxes with green color.
            //Write a LINQ Expression to find the foxes with green color and pallida type.
            Fox foxOne = new Fox("Jedna");
            Fox foxTwo = new Fox("Dva");
            Fox foxThree = new Fox("Tri");
            Fox foxFour = new Fox("Chytri", "chama", "green");
            Fox foxFive = new Fox("Piet", "chama", "green");

            List<Fox> foxes = new List<Fox>();
            foxes.Add(foxOne);
            foxes.Add(foxTwo);
            foxes.Add(foxThree);
            foxes.Add(foxFour);
            foxes.Add(foxFive);

            // Find Green Foxes V1
            var findGreenFoxesA = foxes.Where(f => f.Color == "green").ToList();
            findGreenFoxesA.ForEach(f => Console.WriteLine(f.Name + " is a green fox"));

            // Find Green Foxes V2
            var findGreenFoxesB = from fox in foxes
                                  where fox.Color == "green"
                                  select fox;
            foreach (var fox in findGreenFoxesB)
            {
                Console.WriteLine(fox.Name + " is a green fox");
            }

            // Find Pallida Foxes V1
            var findPallidaFoxesA = foxes.Where(f => f.Type == "pallida").ToList();
            findPallidaFoxesA.ForEach(f => Console.WriteLine(f.Name + " is a pallida fox"));

            // Find Pallida Foxes V2
            var findPallidaFoxes = from fox in foxes
                                   where fox.Type == "pallida"
                                   select fox;

            foreach (var fox in findPallidaFoxes)
            {
                Console.WriteLine(fox.Name + " is a pallida fox");
            }
        }
    }
}
