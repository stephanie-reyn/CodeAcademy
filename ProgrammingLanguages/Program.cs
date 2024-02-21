using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1) // Skips the header
        .Select(line => Language.FromTsv(line)) // Converts each line into a language object
        .ToList(); // Converts sequence of language objs into a list

      /*
      Console.WriteLine("Prints out all languages");
      foreach (var language in languages)
      {
      Console.WriteLine(language.Prettify());
      }
      */

      /*
      Console.WriteLine();
      Console.WriteLine("Returns a string");
      var languageString = languages.Select(l => $"{l.Year}, {l.Name}, {l.ChiefDeveloper}");
      foreach (var v in languageString)
      {
        Console.WriteLine(v);
      }
      */

      Console.WriteLine("When was C# first released");
      var releaseCSharp = from r in languages
      where r.Name.Contains("C#")
      select r;
      foreach (var c in releaseCSharp)
      {
        Console.WriteLine(c.Prettify());
      }

      Console.WriteLine();

      Console.WriteLine("Languages invented by Microsoft");
      var languageMicrosoft = from m in languages
      where m.ChiefDeveloper.Contains("Microsoft")
      select m;
      foreach (var x in languageMicrosoft)
      {
        Console.WriteLine(x.Prettify());
      }

      Console.WriteLine();

      Console.WriteLine("Languages descend from Lisp");
      var descendLisp = from l in languages
      where l.Predecessors.Contains("Lisp")
      select l;
      foreach (var d in descendLisp)
      {
        Console.WriteLine(d.Prettify());
      }

      Console.WriteLine();

      Console.WriteLine("Script languages");
      var languageScript = from s in languages
      where s.Name.Contains("Script")
      select s;
      foreach (var o in languageScript)
      {
        Console.WriteLine(o.Prettify());
      }

      Console.WriteLine();

      var languageCount = languages.Count();
      Console.WriteLine($"Count of languages: {languageCount}");

      Console.WriteLine();

      var launchedLanguage = languages.Where(l => l.Year > 1995 && l.Year < 2005);
      Console.WriteLine($"There were {launchedLanguage.Count()} languages launch between year 1995 and 2005");

      Console.WriteLine();

      var millenniumLanguage = languages
        .Where(m => m.Year > 1995)
        .Select(m => $"{m.Name} was invented in {m.Year}.");
      foreach (var m in millenniumLanguage)
      {
      Console.WriteLine(m);
      }

      

      
    }

    public void PrettyPrintAll(IEnumerable<Language> langs)
    {
      foreach (var print in langs)
      {
        print.Prettify();
      }
    }

    public void PrintAll (IEnumerable<Object> objs)
    {
      foreach (var obj in objs)
      {
        Console.WriteLine(obj);
      }
    }
  }
}
