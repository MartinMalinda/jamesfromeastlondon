using System;
namespace inheritance_exercise
{
    public class Person
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender}.");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
        }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
}

//Create a Person class with the following fields:

//name: the name of the person
//age: the age of the person(whole number)
//gender: the gender of the person(male / female)
//And the following methods:

//Introduce() : prints out "Hi, I'm name, a age year old gender."
//GetGoal() : prints out "My goal is: Live for the moment!"