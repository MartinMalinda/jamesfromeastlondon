using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int currentHoursInSeconds = currentHours * 3600;
            int currentMinutesInSeconds = currentMinutes * 60;
            int secondsInADay = 86400;
            int remainingSecondsInADay = secondsInADay - (currentHoursInSeconds + currentMinutesInSeconds + currentSeconds);

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            Console.WriteLine(remainingSecondsInADay);
        }
    }
}
