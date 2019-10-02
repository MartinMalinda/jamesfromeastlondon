using System;
namespace cloneable
{
    public class Mentor : Person
    {
        public string Level;

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi I'm {Name}, a {Age} year old {Gender} {Level} mentor.");
        }

        public Mentor(string name, int age, string gender, string level)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Level = level;
        }

        public Mentor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Level = "intermediate";
        }
    }
}

//Create a Mentor class that has the same fields and methods as the Person class, and has the following additional

//fields:
//level: the level of the mentor(junior / intermediate / senior)
//methods:
//GetGoal() : prints out "Educate brilliant junior software developers."
//Introduce() : "Hi, I'm name, a age year old gender level mentor."
//The Mentor class has the following constructors:

//Mentor(name, age, gender, level)
//Mentor() : sets name to Jane Doe, age to 30, gender to female, level to intermediate