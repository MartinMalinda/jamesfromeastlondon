using System;
using System.Collections.Generic;

namespace Map
{
    public class ShoppingListProject
    {
        public static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();
            shoppingList.AddRange(new string[] {"Eggs", "milk", "fish", "apples", "bread", "chicken" });

            foreach (var item in shoppingList)
            {
                if (item.Contains("milk"))
                {
                    Console.WriteLine("There is milk on the shopping list");
                }
            }

            foreach (var item in shoppingList)
            {
                if (item.Contains("bananas"))
                {
                    Console.WriteLine("There are bananas on the shopping list");
                }
                else
                {
                    shoppingList.Add("bananas");
                    Console.WriteLine("Just added bananas to the shopping list");
                    break;
                }
            }
        }
    }
}

//We are going to represent a shopping list in a list containing strings.

//Create a list with the following items.
//Eggs, milk, fish, apples, bread and chicken
//Create an application which solves the following problems.
//Do we have milk on the list?
//Do we have bananas on the list?