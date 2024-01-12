using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase ="ABCDEFGHIJKLMNOPQURSTUVWXYZ";
      string lowercase ="abcdefghijklmnopqurstuvwxyz";
      string digits ="0123456789";
      string specialChars ="#?!_-";

      Console.Write("Enter a password: ");
      string userPassword = Console.ReadLine();

      int score = 0;

      if (userPassword.Length >= minLength)
      {
        score++;
      }
      if (Tools.Contains(userPassword, uppercase))
      {
        score++;
      }
      if (Tools.Contains(userPassword, lowercase))
      {
        score++;
      }
      if (Tools.Contains(userPassword, digits))
      {
        score++;
      }
      if (Tools.Contains(userPassword, specialChars))
      {
        score++;
      }

      if (userPassword == "password")
      {
        score = 0;
      }

      if (userPassword == "1234")
      {
        score = 0;
      }

      switch (score)
      {
        case 5:
        Console.WriteLine("The password is extremely strong");
        break;

        case 4:
        Console.WriteLine("The password is extremely strong");
        break;

        case 3:
        Console.WriteLine("The password is strong");
        break;

        case 2:
        Console.WriteLine("The password is medium");
        break;

        case 1:
        Console.WriteLine("The password is weak");
        break;

        default:
        Console.WriteLine("The password doesn't meet any of the standards.");
        break;

      }

    }
  }
}
