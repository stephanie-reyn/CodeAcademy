using System;
using MagicInheritance;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm stm1 = new Storm ("wind", false, "Zul'rajas");
      Console.WriteLine(stm1.Announce());

      Pupil pp1 = new Pupil("Mezil-kree", "Icecrown");
      Storm [] pupilCast = {pp1.CastWindStorm()};

      Mage mg1 = new Mage("Gul'dan", "Draenor");
      Storm[] mageCast = {mg1.CastRainStorm()};

      Archmage amg1 = new Archmage("Nielas Aran", "Stormwind");
      Storm[] archmageCast = {amg1.CastRainStorm(), amg1.CastLightningStorm()};

      foreach (Storm cast in pupilCast)
      {
        Console.WriteLine(cast.Announce());
      }

      foreach (Storm cast in mageCast)
      {
        Console.WriteLine(cast.Announce());
      }

      foreach (Storm cast in archmageCast)
      {
        Console.WriteLine(cast.Announce());
      }


      

      
               
    }
  }
}