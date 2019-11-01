using System;
using System.Collections.Generic;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; private set; }
        public List<string> ListOfTricks { get; private set; }
        public string Food { get; private set; }
        public string Drink { get; private set; }

        public Fox(string name, List<string> listOfTricks, string food, string drink)
        {
            Name = name;
            ListOfTricks = listOfTricks;
            Food = food;
            Drink = drink;
        }

        public Fox(string name)
        {
            Name = name;
        }
    }
}
