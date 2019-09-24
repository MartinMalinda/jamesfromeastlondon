using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FileManipulations
{
    public class ReversedLinesTask
    {
        // Create a method that decrypts reversed-lines.txt

        public static void DecryptDuplicate(string fileEncrypted, string fileDecrypted)
        {
            string inLine = "";
            string outLine = "";

            using (StreamReader sr = new StreamReader(fileEncrypted))
            {
                while ((inLine = sr.ReadLine()) != null)
                {
                    for (int i = inLine.Length - 1; i > -1; i--)
                    {
                        outLine += inLine[i];
                    }
                    outLine += "\n";
                    File.AppendAllText(fileDecrypted, outLine);
                    outLine += "";
                }
            }
        }

        public static void Main(string[] args)
        {
            DecryptDuplicate("reversed-lines.txt", "reversed-lines-decrypted.txt");
        }
    }
}
