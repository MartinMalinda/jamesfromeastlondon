using System;
using Xunit;
using Fibonacci;

namespace Testing
{
    public class UnitTest1
    {
        private GenerateFibonacci generateFibonacci;
        public UnitTest1()
        {
            generateFibonacci = new GenerateFibonacci();
        }

        [Fact]
        public void TestIndexOne()
        {
            int inputOne = 1;
            int inputFive = 5;
            int inputTen = 10;

            Assert.Equal(1, generateFibonacci.GenFibonacci(inputOne));
            Assert.Equal(5, generateFibonacci.GenFibonacci(inputFive));
            Assert.Equal(55, generateFibonacci.GenFibonacci(inputTen));
        }
    }
}