using System;

namespace AppInterface
{
    interface IDisplayable
    {
        public void Display();
        public string HeaderSymbol
        {get; }
    }
}