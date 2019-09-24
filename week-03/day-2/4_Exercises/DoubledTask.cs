using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FileManipulations
{
    public class DoubledTask
    {
        // Create a method that decrypts the duplicated-chars.txt

        public static string DecryptDuplicate (String fileEncrypted, String fileDecrypted)
        {
            String encryptedContent = File.ReadAllText(fileEncrypted);

            for (int charPos = 0; charPos < encryptedContent.Length; charPos += 2)
            {
                char singleLetter = encryptedContent[charPos];
                File.AppendAllText(fileDecrypted, singleLetter.ToString());
            }
            return "File successfully decrypted";
        }

        public static void Main(string[] args)
        {
            string fileEncrypted = @"/Users/jaaames/desktop/HelloMe/duplicated-chars.txt";
            string fileDecrypted = @"/Users/jaaames/desktop/HelloMe/duplicated-chars-decrypted.txt";
            
            Console.WriteLine(DecryptDuplicate(fileEncrypted, fileDecrypted));
        }
    }
}
