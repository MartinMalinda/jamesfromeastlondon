using System;
using System.Collections.Generic;
using System.IO;

namespace Greenfox
{
    public class FileManipulations
    {
        public static void Main(string[] args)
        {
            string[] readFile = File.ReadAllLines(@"reversed-order.txt");
            ReversesOrder(readFile);
        }

        public static void ReversesOrder (string[] readFile)
        {
            string newFile = ("decrypted-reversed-order.txt");
            
            for (int lineRead = readFile.Length - 1; lineRead > 0; lineRead--)
            {
                Console.WriteLine(readFile[lineRead]);
                File.AppendAllText(newFile, readFile[lineRead] + Environment.NewLine);
            }
        }
    }
}

// Create a method that decrypts reversed-order.txt