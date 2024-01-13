using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      // BuildACreature("ghost", "monster", "bug");
      // SwitchCase(1,1,1);

      RandomMode();
    }

    static void BuildACreature(string head, string body, string feet)
    {
      int headNum = TranslateToNumber("ghost");
      int bodyNum = TranslateToNumber("bug");
      int feetNum = TranslateToNumber("monster");
    }

    static void RandomMode()
    {
      Random randomNumber = new Random();
      int head = randomNumber.Next(1, 4);
      int body = randomNumber.Next(1, 4);
      int feet = randomNumber.Next(1, 4);

      SwitchCase(head, body, feet);
    }

    static void SwitchCase(int headNum, int bodyNum, int feetNum)
    {
      switch (headNum)
      {
        case 1:
        GhostHead();
        break;

        case 2:
        BugHead();
        break;

        case 3:
        MonsterHead();
        break;
      }

      switch (bodyNum)
      {
        case 1:
        GhostBody();
        break;

        case 2:
        BugBody();
        break;

        case 3:
        MonsterBody();
        break;
      }

      switch (feetNum)
      {
        case 1:
        GhostFeet();
        break;

        case 2:
        BugFeet();
        break;

        case 3:
        MonsterFeet();
        break;
      }
    }

    static int TranslateToNumber(string creature)
    {
      switch (creature)
      {
  
        case "ghost":
        return 1;

        case "bug":
        return 2;

        case "monster":
        return 3;

        default:
        return 1;

      }
    }


    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
