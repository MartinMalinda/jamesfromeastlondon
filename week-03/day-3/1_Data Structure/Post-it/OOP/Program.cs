using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postItOne = new PostIt();
            {
                postItOne.backgroundColor = "Orange";
                postItOne.text = "Idea 1";
                postItOne.textColor = "Blue";
            }
            PostIt postItTwo = new PostIt();
            {
                postItTwo.backgroundColor = "Pink";
                postItTwo.text = "Awesome";
                postItTwo.textColor = "Black";
            }
            PostIt postItThree = new PostIt();
            {
                postItThree.backgroundColor = "Yellow";
                postItThree.text = "Superb!";
                postItThree.textColor = "Green";
            }
        }   
    }
}
