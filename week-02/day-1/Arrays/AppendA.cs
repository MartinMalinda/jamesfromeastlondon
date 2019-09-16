using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            // - Add all elements an `"a"` at the end

            string[] animals = { "koal", "pand", "zebr" };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal + "a");
            }

            Console.ReadLine();
        }
    }
}