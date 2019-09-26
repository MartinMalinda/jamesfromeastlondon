using System;
using System.Collections.Generic;

namespace DiceSet
{
    class Program
    {
        public static void Main(string[] argv)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6
            DiceSet diceSet = new DiceSet();

            diceSet.Roll();
            foreach (var value in diceSet.GetCurrent())
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            for (int i = 0; i < diceSet.GetCurrent().Length; i++)
            {
                do
                {
                    diceSet.Reroll(i);
                    foreach (var value in diceSet.GetCurrent())
                    {
                        Console.Write($"{value} ");
                    }
                    Console.WriteLine();
                } while (diceSet.GetCurrent(i) != 6);
            }
        }
    }
}

