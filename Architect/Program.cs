using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(rectangle(4, 5));
      Console.WriteLine(circle(4));
      Console.WriteLine(triangle(10, 9));
      
      double totalArea = rectangle(2500, 1500) + (circle(375) / 2) + triangle(750,500);
      double roundedArea = Math.Round(totalArea, 2);
      totalArea = roundedArea;

      double totalCost = totalArea * 180;
      double roundedCost = Math.Round(totalCost, 2);
      totalCost = roundedCost;

      Console.WriteLine($"The total are of the Teotihuacan is {totalArea} and the cost of flooring is going to be {totalCost} Mexican pesos.");     

    
    }

    static double rectangle (double length, double width)
    {
      double rectArea = length * width;
      return rectArea;
    }

    static double circle (double radius)
    {
      double circArea = Math.PI * Math.Pow(radius, 2);
      return circArea;
    }

    static double triangle (double bottom, double height)
    {
      double triArea = 0.5 * bottom * height;
      return triArea;
    }

  }
}
