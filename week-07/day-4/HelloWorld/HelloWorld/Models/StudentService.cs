using System;
using System.Collections.Generic;

namespace HelloWorld.Models
{
    public class StudentService
    {
        private readonly List<string> names;
        private int count;

        public StudentService()
        {
            names = new List<string> { "Sanyi", "Lilla", "John" };
        }

        public List<string> FindAll()
        {
            return names;
        }

        public void Save(string student)
        {
            names.Add(student);
        }

        public int Count()
        {
            count = names.Count;
            return count;
        }

        public string Check(string student)
        {
            if (names.Contains(student))
            {
                return " exists";
            }
            return " does not exist";
        }
    }
}
