using System;
using System.Collections.Generic;

namespace Sum
{
    public class Summing
    {
        public int SumOfList (List<int> list)
        {
            int sum = 0;
            foreach (var num in list)
            {
                sum += num;
            }
            return sum;
        }
        public int? SumOfList(List<int?> list)
        {
            int? sum = null;
            foreach (var num in list)
            {
                sum += num;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

//Create a sum method in your class which takes a List of integers as parameter
//It should return the sum of the elements in the list
//Follow these steps:
//Create an xUnit project
//Add a Test class to your project
//Add a new Test case in it
//Instantiate your class (arrange, act, assert)
//create a list of integers
//use the Assert.Equal() to test the result of the created sum method
//Run them
//Create different tests where you test your method with:
//an empyt list
//a list that has one element in it
//a list that has multiple elements in it
//a null
//Run them
//Fix your code if needed