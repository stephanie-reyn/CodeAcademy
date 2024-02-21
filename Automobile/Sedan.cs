using System;
using System.Security.Cryptography.X509Certificates;

namespace LearningInterface
{
    class Sedan : IAutomobile
    {
        public string LicensePlate
        {get; }
        
        public double Speed
        {get; private set;}

        public int Wheels
        {get; }

        public Sedan (double speed, string licensePlate)
        {
            this.Speed = speed;
            this.LicensePlate = licensePlate;
            this.Wheels = 4;
        }

        public void Honk()
        {
            Console.WriteLine("Honk!");
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