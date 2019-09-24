using System;
using System.IO;
using System.Linq;

namespace FileManipulations
{
    public class CountLinesTask
    {
        // Write a function that takes a filename as string,
        // then returns the number of lines the file contains.
        // It should return zero if it can't open the file, and
        // should not raise any error.

        public static void Main(string[] args)
        {
            string getFileName;
            try
            {
                string fileName = @"./file.txt";
                getFileName = Path.GetFileName(fileName);
                int fileLineCount = File.ReadLines(@"./file.txt").Count();
                Console.WriteLine($"{getFileName} contains {fileLineCount} lines");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(0);
            }
        }
    }
}
