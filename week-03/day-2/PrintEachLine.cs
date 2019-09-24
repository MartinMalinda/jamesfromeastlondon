using System;
using System.IO;

namespace FileManipulations
{
    public class PrintEachLineTask
    {
        // Write a program that opens a file called "my-file.txt", then prints
        // each line from the file.
        // If the program is unable to read the file (for example it does not exist),
        // then it should print the following error message: "Unable to read file: my-file.txt"

        public static void Main(string[] args)
        {
            string fileContent = "";

            try
            {
                fileContent = File.ReadAllText("./my-file.text");
            }
            catch (IOException e)
            {
                Console.Error.WriteLine(e);
                Console.WriteLine($"Unable to read file: my-file.text");
            }
            Console.WriteLine(fileContent);
        }
    }
}
