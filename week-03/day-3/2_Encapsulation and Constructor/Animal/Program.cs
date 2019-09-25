using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Animal();
            {
                lion.Eat();
                lion.Play();
                Console.WriteLine($"The lion's hunger is: {lion.hunger}\nThe lion's thirst is: {lion.thirst}");
            }
        }   
    }
}

// Create an Animal class
// Every animal has a hunger value, which is a whole number
// Every animal has a thirst value, which is a whole number
// when creating a new animal object these values are created with the default 50 value
// Every animal can Eat() which decreases their hunger by one
// Every animal can Drink() which decreases their thirst by one
// Every animal can Play() which increases both by one
