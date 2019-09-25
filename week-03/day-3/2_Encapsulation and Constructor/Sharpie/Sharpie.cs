using System;
namespace OOP
{
    public class Sharpie
    {
        public string color { get; set; }
        public float width { get; set; }
        public float inkAmount { get; set; } = 100f;

        public Sharpie()
        {

        }

        public Sharpie(string color, float width)
        {
            this.color = color;
            this.width = width;
        }

        public float Use()
        {
            return inkAmount--;
        }
    }
}

//Create Sharpie class
//We should know about each sharpie their Color(which should be a string), Width(which will be a floating point number),
//InkAmount(another floating point number)
//When creating one, we need to specify the Color and the Width
//Every sharpie is created with a default 100 as InkAmount
//We can Use() the sharpie objects
//which decreases inkAmount
