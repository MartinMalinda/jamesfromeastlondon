using System;
using System.Collections.Generic;
using Xunit;
using Sum;

namespace Testing
{
    public class UnitTest1
    {
        private Summing summing;
        public UnitTest1()
        {
            summing = new Summing();
        }

        [Fact]
        public void TestSum()
        {
            List<int> listOfNum = new List<int>();
            listOfNum.Add(1);
            listOfNum.Add(2);
            listOfNum.Add(3);

            int output = summing.SumOfList(listOfNum);

            Assert.Equal(6, output);
        }

        [Fact]
        public void TestEmpty()
        {
            List<int> listOfNum = new List<int>();

            int output = summing.SumOfList(listOfNum);

            Assert.Equal(0, output);
        }

        [Fact]
        public void TestSingleElement()
        {
            List<int> listOfNum = new List<int>();
            listOfNum.Add(1);

            int output = summing.SumOfList(listOfNum);

            Assert.Equal(1, output);
        }

        [Fact]
        public void TestNull()
        {
            int? nullValue = null;
            List<int?> listOfNum = new List<int?>();
            listOfNum.Add(nullValue);

            int? output = summing.SumOfList(listOfNum);

            Assert.Null(output);
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