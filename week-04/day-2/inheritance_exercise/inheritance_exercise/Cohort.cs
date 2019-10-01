using System;
using System.Collections.Generic;

namespace inheritance_exercise
{
    public class Cohort
    {
        private string name;
        private List<Student> students;
        private List<Mentor> mentors;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {Name} cohort has {students.Count} students and {mentors.Count} mentors.");
        }

        public Cohort(string name)
        {
            Name = name;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }
    }
}

//Create a Cohort class that has the following

//fields:
//name: the name of the cohort
//students: a list of Students
//mentors: a list of Mentors
//methods:
//addStudent(Student) : adds the given Student to students list
// addMentor(Mentor): adds the given Mentor to mentors list
// info(): prints out "The name cohort has students.size() students and mentors.size() mentors."
//The Cohort class has the following constructors:

//Cohort(name) : beside the given parameter, it sets students and mentors as empty lists