using System;
using System.Reflection.Metadata;

namespace ArichitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What momument would you like to work with?"); 
            Console.Write("Teotihuacan, Taj Mahal or Great Mosque of Mecca? ");

            string userAnswer = Console.ReadLine();
            double momumentCost = Math.Round(CalculateTotalCost(userAnswer), 2);
            Console.WriteLine($"The plan for that momument costs {momumentCost} pesos!");
        }

        public static double CalculateTotalCost(string userAnswer)
        {

            double areaOne = (2500 * 1500) + (Math.PI * Math.Pow(375,2)/2) + (0.5 * 750 * 500);
            double costOne = areaOne * 180;

            double areaTwo = (90.5 * 90.5) - (((24 * 24) / 2) * 4);
            double costTwo = areaTwo * 180;
           
            double areaThree = (200 * 264) + ((84 * 264) / 2) + (180 * 106);
            double costThree = areaThree * 180;

            double totalCost;

            if (userAnswer == "Teotihuacan")
            {
               totalCost = costOne;
            }

            else if (userAnswer == "Taj Mahal")
            {
                totalCost = costTwo;
            }

            else if (userAnswer == "Great Mosque of Mecca")
            {
                totalCost = costThree;
                
            }

            else
            {
                totalCost = 0;
            }
            
            return totalCost;

        }
    }
}