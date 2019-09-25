using System;
namespace OOP
{
    public class PostIt
    {
        public string backgroundColor { get; set; }
        public string text { get; set; }
        public string textColor { get; set; }

        public PostIt()
        {

        }

        public PostIt(string backgroundColor, string text, string textColor)
        {
            this.backgroundColor = backgroundColor;
            this.text = text;
            this.textColor = textColor;
        }
    }
}
