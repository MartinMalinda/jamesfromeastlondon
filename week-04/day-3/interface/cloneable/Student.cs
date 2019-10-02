using System;

namespace cloneable
{
    public class Student : Person, ICloneable
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public object Clone()
        {
            return new Student(Name, Age, Gender, PreviousOrganization);
            //var student = (Student)MemberwiseClone();
            //return student;
        }
        
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer");
        }

        public void SkipDays()
        {
            SkippedDays += 1;
        }

        public void SkipDays(int num)
        {
            SkippedDays += num;
        }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            Name = name;
            Age = age;
            Gender = gender;
            PreviousOrganization = previousOrganization;
            SkippedDays = 0;
        }

        public Student()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
        }
    }
}
//Create a Student class that has the same fields and methods as the Person class, and has the following additional

//fields:
//previousOrganization: the name of the student’s previous company / school
//skippedDays: the number of days skipped from the course
//methods:
//GetGoal() : prints out "Be a junior software developer."
//Introduce() : "Hi, I'm name, a age year old gender from previousOrganization who skipped skippedDays days from the course already."
//SkipDays(numberOfDays) : increases skippedDays by numberOfDays
//The Student class has the following constructors:

//Student(name, age, gender, previousOrganization) : beside the given parameters, it sets skippedDays to 0
//Student() : sets name to Jane Doe, age to 30, gender to female, previousOrganization to The School of Life, skippedDays to 0