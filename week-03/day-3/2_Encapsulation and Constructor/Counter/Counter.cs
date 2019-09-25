using System;
namespace OOP
{
    public class Counter
    {
        public int counter { get; set; } = 0;

        public int Add()
        {
            return Add(1);
        }

        public int Add(int num)
        {
            return counter += num;
        }

        public string Get()
        {
            string counterCurrentValue = counter.ToString();
            return counterCurrentValue;
        }

        public int Reset()
        {
            return counter = 0;
        }
    }
}

//Create Counter class
//which has an integer property
//when creating it should have a default value 0 or we can specify it when creating
//we can Add(number) to this counter another whole number
//or we can Add() without parameters just increasing the counter's value by one
//and we can Get() the current value as string
//also we can Reset() the value to the initial value
