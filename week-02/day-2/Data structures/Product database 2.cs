using System;
using System.Collections.Generic;

namespace Map
{
    public class ProductDatabaseProjectTwo
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> productDatabase = new Dictionary<string, int>()
            {
                { "Eggs", 200},
                { "Milk", 200},
                { "Fish", 400},
                { "Apples", 150},
                { "Bread", 50},
                { "Chicken", 550}
            };

            Console.WriteLine("These items cost < 201: ");
            foreach (var item in ProductLessThan(productDatabase))
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("\nThese items cost > 150: ");
            foreach (var item in ProductsMoreThan(productDatabase))
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> ProductLessThan(Dictionary<string, int>dict)
        {
            List<string> productNames = new List<string>();
            foreach (var item in dict)
            {
                if (item.Value < 201)
                {
                    productNames.Add(item.Key);
                }
            }
            return productNames;
        }

        public static Dictionary<string, int> ProductsMoreThan(Dictionary<string, int> dict)
        {
            Dictionary<string, int> newDict = new Dictionary<string, int>();

            foreach (var item in dict)
            {
                if (item.Value > 150)
                {
                    newDict.Add(item.Key, item.Value);
                }
            }
            return newDict;
        }
    }
}

//We are going to represent our products in a map where the keys are strings representing the product's name
//and the values are numbers representing the product's price.

//Create a map with the following key-value pairs.

//Product name (key) Price (value)
//Eggs	  200
//Milk    200
//Fish    400
//Apples  150
//Bread   50
//Chicken 550
//Create an application which solves the following problems.

//Which products cost less than 201? (just the name)
//Which products cost more than 150? (name + price)