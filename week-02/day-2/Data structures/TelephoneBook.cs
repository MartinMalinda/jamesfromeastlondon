using System;
using System.Collections.Generic;

namespace Map
{
    public class PhoneBookProject
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>()
            {
                { "William A.Lathan", "405-709-1865" },
                { "John K. Miller", "402-247-8568" },
                { "Hortensia E. Foster", "606-481-6467" },
                { "Amanda D. Newland", "319-243-5613" },
                { "Brooke P. Askew", "307-687-2982" } 
            };

            foreach (var contact in PhoneBook)
            {
                if (contact.Key.Contains("John K. Miller"))
                {
                    Console.WriteLine(contact.Value);
                }
            }

            foreach (var contact in PhoneBook)
            {
                if (contact.Value.Contains("307-687-2982"))
                {
                    Console.WriteLine(contact.Key);
                }
            }

            foreach (var contact in PhoneBook)
            {
                if (contact.Key.Contains("Chris E.Myers"))
                {
                    Console.WriteLine(contact.Value);
                }
                else
                {
                    Console.WriteLine("Chris E.Myers' phone number does not exist");
                    break;
                }
            }
        }
    }
}

//We are going to represent our contacts in a map where the keys are going to be strings and the values are going to be strings as well.

//Create a map with the following key-value pairs.

//Name(key)  Phone number(value)
//William A.Lathan   405-709-1865
//John K. Miller  402-247-8568
//Hortensia E. Foster 606-481-6467
//Amanda D. Newland   319-243-5613
//Brooke P. Askew 307-687-2982
//Create an application which solves the following problems.

//What is John K. Miller's phone number?
//Whose phone number is 307-687-2982?
//Do we know Chris E.Myers' phone number?