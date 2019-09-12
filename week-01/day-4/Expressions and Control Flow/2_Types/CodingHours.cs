using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            int semesterWeeks = 17;
            int semesterWorkDays = semesterWeeks * 5;
            int semesterCodingTime = semesterWorkDays * 6;
            double weeklyCodingTime = 6 * 5;
            int averageWeeklyWorkHours = 52;
            double percentageOfCodingHours = Math.Round((weeklyCodingTime / averageWeeklyWorkHours) * 100, 2);

            Console.WriteLine("Over 17 weeks of coding on workdays, the average Green Fox attendee codes for {0} hours", semesterCodingTime);
            Console.WriteLine("With average weekly work hours of {0}, the percentage of coding hours would be {1}%", averageWeeklyWorkHours, percentageOfCodingHours);
        }
    }
}
