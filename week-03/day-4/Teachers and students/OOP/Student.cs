using System;
namespace OOP
{
    public class Student
    {
        public Student()
        {
        }

        public static void Learn()
        {
            Console.WriteLine("The student is learning something new");
        }

        public static void Question()
        {
            Teacher.Answer();
        }
    }
}

//Student
//Learn() -> prints the student is learning something new
//Question(teacher) -> calls the teachers answer method