using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie blueSharpie = new Sharpie("blue", 1.2f);
            {
                blueSharpie.Use();
                Console.WriteLine($"The blue sharpie has this much ink left: {blueSharpie.inkAmount}");
            }
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
