using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string ? entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string [] questions = {"Arachnophonia is the fear of bathing." , "Boiling water is 100 degrees Celsius." , "The sun is not a star." , "An octopus has one heart." , "Pigs roll in the mud because it helps to keep them cool." };
      bool [] answers = {false, true, false, false, true};
      bool [] responses = new bool [answers.Length];

      if (answers.Length != responses.Length)
      {
        Console.WriteLine("Too many input");
      };

      int askingIndex = 0;
      foreach (string question in questions)
      {
        Console.WriteLine(question);
        Console.Write("True or False: ");
        string ? input = Console.ReadLine();
        bool isBool = Boolean.TryParse(input, out bool inputbool);
        bool inputBool = isBool;

        while (!isBool)
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          string ? newInput = Console.ReadLine();
          isBool = Boolean.TryParse(newInput, out inputBool);
        }

        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      foreach (bool response in responses)
      {
      Console.WriteLine(response);
      };
     

    }
  }
}
