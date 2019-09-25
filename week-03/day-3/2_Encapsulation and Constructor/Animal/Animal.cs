using System;
namespace OOP
{
    public class Animal
    {
        public int hunger { get; set; } = 50;
        public int thirst { get; set; } = 50;

        public Animal()
        {

        }

        public Animal(int hunger, int thirst)
        {
            this.hunger = hunger;
            this.thirst = thirst;
        }

        public void Eat()
        {
            hunger--;
        }

        public void Drink()
        {
            thirst--;
        }

        public void Play()
        {
            hunger++;
            thirst++;
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
