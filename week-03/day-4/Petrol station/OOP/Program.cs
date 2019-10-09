using System;
using System.Collections.Generic;

namespace OOP
{
    public class TeachersAndStudents
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            Station station = new Station(500);
            {
                station.Refill(car);
                Console.WriteLine($"Car Gas Amount: {car.GasAmount}");
                Console.WriteLine($"Car Capacity: {car.Capacity}");
            }
        }
    }
}
