using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;

            // BMI Formula: weight (kg) / [height (m)]2
            double bmiFormula = Math.Round(massInKg / (heightInM * heightInM), 2);

            Console.WriteLine(bmiFormula);
        }
    }
}