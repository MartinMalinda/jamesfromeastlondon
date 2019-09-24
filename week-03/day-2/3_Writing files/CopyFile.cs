using System;
using System.IO;
using System.Linq;

namespace FileManipulations
{
    public class CopyFileTask
    {
        // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
        // It should take the filenames as parameters
        // It should return a boolean that shows if the copy was successful

        public static string ReadThenWriteFile (String filename, String path)
        {
            string readContent = File.ReadAllText(filename);
            File.WriteAllText(path, readContent);

            return "Copy was successful";
        }

        public static void Main(string[] args)
        {
            string fileSource = @"/Users/jaaames/desktop/HelloMe/Helloworld.txt";
            string fileNewCopy = @"/Users/jaaames/desktop/HelloMe/HelloworldNewCopy.txt";
            
            Console.WriteLine(ReadThenWriteFile(fileSource, fileNewCopy));
        }
    }
}
