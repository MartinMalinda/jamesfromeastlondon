using System;
using System.IO;
using System.Linq;

namespace FileManipulations
{
    public class WriteSingleLineTask
    {
        // Write a function that is able to manipulate a file
        // By writing your name into it as a single line
        // The file should be named "my-file.txt"
        // In case the program is unable to write the file,
        // It should print the following error message: "Unable to write file: my-file.txt"

        public static void Main(string[] args)
        {
            string fileName = @"./file.txt";
            string getFileName = Path.GetFileName(fileName);

            try
            {
                File.WriteAllText("./file.txt", "James");
            } catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Unable to write file: {getFileName}");
            }
        }
    }
}
