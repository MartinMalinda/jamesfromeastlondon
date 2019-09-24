using System;
using System.IO;
using System.Linq;

namespace FileManipulations
{
    public class WriteMultipleLinesTask
    {
        // Create a function that takes 3 parameters: a path, a word and a number
        // and is able to write into a file.
        // The path parameter should be a string that describes the location of the file you wish to modify
        // The word parameter should also be a string that will be written to the file as individual lines
        // The number parameter should describe how many lines the file should have.
        // If the word is 'apple' and the number is 5, it should write 5 lines
        // into the file and each line should read 'apple'
        // The function should not raise any errors if it could not write the file.

        public static void WriteFile (String path, String words, int number)
        {
            try
            {
                for (int lines = 0; lines < number; lines++)
                {
                    File.AppendAllText(path, words);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Unable to write file");
            }
        }

        public static void Main(string[] args)
        {
            string filePath = @"/Users/jaaames/desktop/HelloMe/Helloworld.txt";
            string fileText = "Hello world!\n";

            WriteFile(filePath, fileText, 5);
        }
    }
}
