using System;
using AppInterface;

namespace AppInterface
{
    class TodoList : IDisplayable, IResetable
    {
        // Property
        public string[] Todos
        { get; private set; }

        // Field
        private int nextOpenIndex;
        private bool limitExceeded;

        // Constructor
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
            limitExceeded = false;
        }

        public string HeaderSymbol => "-";


        // Method
        public void Add(string todo)
        {
            if (nextOpenIndex < Todos.Length)
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
            else
            {
                Console.WriteLine("Cannot add more than five todos. Try again");
                Reset();
                limitExceeded = true;
            }
        }

        public void Display()
        {
            if (!limitExceeded)
            {
                Console.WriteLine("Todos");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(HeaderSymbol);
                }
                Console.WriteLine("");
                if (nextOpenIndex > 0)
                {
                    foreach (string dos in Todos)
                    {
                        Console.WriteLine(string.IsNullOrEmpty(dos) ? "[]" : dos);
                    }
                }
                else
                {
                    Console.WriteLine("Too many todos listed. Try again.");
                }
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
            limitExceeded = false;
        }
    }
}
