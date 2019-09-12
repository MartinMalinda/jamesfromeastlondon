using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            double cuboidSide1 = 10;
            double cuboidSide2 = 10;
            double cuboidSide3 = 10;
            double cuboidSurfaceArea = 6 * (cuboidSide1 * cuboidSide2);
            double cuboidVolume = cuboidSide1 * cuboidSide2 * cuboidSide3;

            Console.WriteLine("Surface Area: " + cuboidSurfaceArea);
            Console.WriteLine("Volume: " + cuboidVolume);
        }
    }
}