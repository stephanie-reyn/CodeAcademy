using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("Enter an amount to convert to coins");
      double userInput = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine($"{userInput} cents is equal to ...");

      double goldValue = 10;
      double silverValue = 5;

      double goldCoins = Math.Floor(userInput / goldValue);
      double goldRest = userInput % goldValue;

      double silverCoins = Math.Floor(goldRest / silverValue);
      double remainder = goldRest % silverValue; 

      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");



    }
  }
}
