using System;
using System.Collections.Generic;
using Xunit;
using Count_Letters;

namespace Testing
{
    public class UnitTest1
    {
        private CountingLetters countingLetters;
        public UnitTest1()
        {
            countingLetters = new CountingLetters();
        }

        [Theory]
        [InlineData ("Wassup")]
        void TestCountLetters (string input)
        {
            Assert.IsType<Dictionary<char, int>>(countingLetters.StringToDictionary(input));
        }
    }
}
