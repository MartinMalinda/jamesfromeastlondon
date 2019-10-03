using System;
using Xunit;
using Anagram;

namespace Testing
{
    public class UnitTest1
    {
        private Anagrammy anagrammy;
        public UnitTest1()
        {
            anagrammy = new Anagrammy();
        }

        [Fact]
        public void TestAnagramChecker()
        {
            string strA = "hello";
            string strB = "olleh";

            bool result = anagrammy.AnagramChecker(strA, strB);

            Assert.True(result);
        }
    }
}

//Write a function, that takes two strings and returns a boolean value
//based on if the two strings are Anagramms or not.
//Create a test for that.