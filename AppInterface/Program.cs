using System;

namespace AppInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");

      PasswordManager pm = new PasswordManager("iluvpie", true);

      tdl.Display();
      pm.Display();

      TodoList tdl2 = new TodoList();
      tdl2.Add("Do homework");
      tdl2.Add("Go for a walk");
      tdl2.Add("Train");
      tdl2.Add("Nap");
      tdl2.Add("Make matcha tea");
      tdl2.Add("Play games");

      tdl2.Display();

      pm.ChangePassword("iluvpies", "ihatepies");
  
    }
  }
}
