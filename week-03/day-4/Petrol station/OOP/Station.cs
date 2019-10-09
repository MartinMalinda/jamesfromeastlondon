using System;
namespace OOP
{
    public class Station
    {
        public int GasAmount { get; set; }

        public Station(int gasAmount)
        {
            this.GasAmount = gasAmount;
        }

        public void Refill(Car car)
        {
            this.GasAmount -= car.Capacity;
            car.GasAmount += car.Capacity;
            car.Capacity -= car.GasAmount;
            Console.WriteLine($"Station Gas Amount: {this.GasAmount}");
        }
    }
}

//Station
//GasAmount
//Refill(car) -> decreases the gasAmount by the capacity of the car and increases the cars gasAmount