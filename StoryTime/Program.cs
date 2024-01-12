using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine($"It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you investige?");
      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      string noiseChoiceUpper = noiseChoice.ToUpper();
      noiseChoice = noiseChoiceUpper;


      if (noiseChoice == "NO")
      {
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
        Console.WriteLine("THE END");
      }

      else if (noiseChoice == "YES")
      {
       Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
       Console.WriteLine("You walk towards it. Do you open it or knock?") ;
      }

      Console.Write("TYPE OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine();
      string doorChoiceUpper = doorChoice.ToUpper();
      doorChoice = doorChoiceUpper;

      if (doorChoice == "KNOCK")
      {
       Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\"");
       Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");

       Console.Write("Type your answer: ");
       string riddleAnswer = Console.ReadLine();
       string riddleAnswerUpper = riddleAnswer.ToUpper();
       riddleAnswer = riddleAnswerUpper;

       if (riddleAnswer == "NOTHING")
       {
        Console.WriteLine("The door opens and NOTHING is there.");
        Console.WriteLine("You turn off the light and run back to your room and lock the door.");
        Console.WriteLine("THE END");
       }

       else
       {
        Console.WriteLine("You answered incorrectly. The door doesn't open.");
        Console.WriteLine("THE END");
       }
      }
      
      else if (doorChoice == "OPEN")
      {
        Console.WriteLine("The door is locked! See if one of your three keys will open it");

       Console.Write("Enter a number (1 - 3): ");
       string keyChoice = Console.ReadLine();

      switch (keyChoice)
      {
        case "1":
        Console.WriteLine("You chose the first key. Lucky choice! \n The door opens and NOTHING is there. \n Strange....");
        Console.WriteLine("THE END");
        break;

        case "2":
        Console.WriteLine("You chose the second key. \n The door doesn't open.");
        Console.WriteLine("THE END");
        break;

        case "3":
        Console.WriteLine("You chose the third key. \n The door doesn't open");
        Console.WriteLine("THE END");
        break;

        default:
        Console.WriteLine("You didn't choose any key.\n You went back to your room and went back to sleep.");
        Console.WriteLine("THE END");
        break;
      } 

      }


      

    }
  }
}



