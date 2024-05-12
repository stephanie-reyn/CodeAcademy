using System;

namespace Assignment3 {
    public class Program {
        public static void Main() {
            Console.WriteLine("Press ESC key to close window");
            Game game = new Game();
            game.Run();
            Console.WriteLine("All Done");
        }
    }
}
