using System;

namespace LearningInterface
{
    class Truck : IAutomobile
    {
        public string LicensePlate
        {get; }

        public double Speed
        {get; private set; }

        public int Wheels
        {get; }

        public double Weight
        {get; }

        public void Honk()
        {
            Console.WriteLine("Honk!");
        }

        public Truck (double speed, string licensePlate, double weight)
        {
            this.Speed = speed;
            this.LicensePlate = licensePlate;
            this.Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }      
        }

        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }
    }
}