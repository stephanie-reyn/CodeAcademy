using System;

namespace LearningInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan car1 = new Sedan(60, "AT1234");
            Sedan car2 = new Sedan(70, "AT0987");
            Truck truck1 = new Truck(45, "AT4567", 500);

            Console.WriteLine($"The first Sedan's speed is {car1.Speed} and its license plate is {car1.LicensePlate}.");
            Console.WriteLine($"The second Sedan's speed is {car2.Speed} and its license plate is {car2.LicensePlate}.");
            Console.WriteLine($"The truck's speed is {truck1.Speed}, its license plate is {truck1.LicensePlate} and weighs {truck1.Weight}.");

            car1.SpeedUp();
            car2.SpeedUp();
            truck1.SpeedUp();

            Console.WriteLine($"Vehicle's new speed are:\nFirst Sedan: {car1.Speed}\nSecond Sedan: {car2.Speed}\nTruck: {truck1.Speed}");


        }
    }

}