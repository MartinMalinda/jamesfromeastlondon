using System;
using Xunit;
using Apples;

namespace Testing
{
    public class UnitTest1
    {
        private Applez applez;
        public UnitTest1()
        {
            applez = new Applez();
        }

        [Fact]
        public void TestString()
        {
            Assert.Equal("apple", applez.GetApple());
        }
    }
}

//Create a class, with one method(eg. public string GetApple()) that returns a string (eg. "apple")
//Create a test for that.
//Create an xUnit project
//Add a new Test case in it
//Instantiate your class (arrange, act, assert)
//Use the Assert.Equal()
//The expected parameter should be the same string (eg. "apple")
//The actual parameter should be the return value of the method(eg.myObject.GetApple())
//Run the test
//Change the expected value to make the test failing
//Run the test
//Fix the returned value to make the test succeeding again