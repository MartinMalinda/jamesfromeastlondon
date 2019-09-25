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

// Create a PostIt a class that has
// a BackgroundColor
// a Text on it
// a TextColor
// Create a few example post-it objects:
// an orange with blue text: "Idea 1"
// a pink with black text: "Awesome"
// a yellow with green text: "Superb!"
