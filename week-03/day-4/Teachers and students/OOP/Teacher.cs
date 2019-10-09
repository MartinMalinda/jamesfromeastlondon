using System;
namespace OOP
{
    public class Teacher
    {
        public Teacher()
        {
        }

        public static void Teach()
        {
            Student.Learn();
        }

        public static void Answer()
        {
            Console.WriteLine("Teacher is answering a question");
        }

    }
}

//Teacher
//Teach(student) -> calls the students learn method
//Answer() -> prints the teacher is answering a question