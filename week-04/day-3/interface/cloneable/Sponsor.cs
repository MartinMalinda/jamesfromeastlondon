using System;
namespace cloneable
{
    public class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public int HiredStudents
        {
            get { return hiredStudents; }
            set { hiredStudents = value; }
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi I'm {Name}, a {Age} year old {Gender} who represents {company} and hired {hiredStudents} students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            hiredStudents += 1;
        }

        public Sponsor(string name, int age, string gender, string company)
        {
            Name = name;
            Age = age;
            Gender = gender;
            this.company = company;
        }

        public Sponsor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            company = "Google";
            hiredStudents = 0;
        }
    }
}

//Create a Sponsor class that has the same fields and methods as the Person class, and has the following additional

//fields:
//company: name of the company
//hiredStudents: number of students hired
//method:
//Introduce() : "Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far."
//Hire() : increase hiredStudents by 1
//GetGoal() : prints out "Hire brilliant junior software developers."
//The Sponsor class has the following constructors:

//Sponsor(name, age, gender, company) : beside the given parameters, it sets hiredStudents to 0
//Sponsor() : sets name to Jane Doe, age to 30, gender to female, company to Google and hiredStudents to 0