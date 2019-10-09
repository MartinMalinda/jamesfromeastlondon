using System;
using System.Collections.Generic;

namespace OOP
{
    public class TeachersAndStudents
    {
        public static void Main(string[] args)
        {
            Student bob = new Student();
            {
                Student.Question();
            }

            Teacher tim = new Teacher();
            {
                Teacher.Teach();
            }
        }
    }
}

//Create Student and Teacher classes
//Instantiate a Student and Teacher object
//Call the student's Question() method and the teacher's Teach() method