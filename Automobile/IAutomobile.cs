using System;
namespace LearningInterface
{
    interface IAutomobile
    {
        string LicensePlate {get; }
        double Speed {get; }
        int Wheels {get; }
        void Honk();
        
    }

}