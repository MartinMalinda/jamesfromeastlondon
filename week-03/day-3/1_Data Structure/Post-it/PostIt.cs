using System;
namespace OOP
{
    public class PostIt
    {
        public string backgroundColor { get; set; }
        public string text { get; set; }
        public string textColor { get; set; }

        public PostIt(string backgroundColor, string text, string textColor)
        {
            this.backgroundColor = backgroundColor;
            this.text = text;
            this.textColor = textColor;
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
