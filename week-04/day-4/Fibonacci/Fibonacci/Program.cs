using System;

namespace Fibonacci
{
    public class GenerateFibonacci
    {
        public int GenFibonacci(int num)
        {
            if (num <= 1)
            {
                return num;
            }
            return GenFibonacci(num - 1) + GenFibonacci(num - 2);
        }
    }
    class Program
    {
        public static int GenFibonacci(int num)
        {
            if (num <= 1)
            {
                return num;
            }
            return GenFibonacci(num - 1) + GenFibonacci(num - 2);
        }
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine(GenFibonacci(num)); 
        }
    }
}

//Write a function that computes a member of the fibonacci sequence by a given index
//Create tests for multiple test cases.