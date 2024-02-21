using System;

namespace MagicInheritance
{
    class Mage : Pupil
    {
        // inherited Properties
        public new string Title
        {get; private set; }

        public new string Origin
        {get; private set; }

        // Constructor - inhering from Pupil
        public Mage (string title, string origin) : base(title, origin)
        {
            this.Title = title;
            this.Origin = origin;
        }

        // Method
        public virtual Storm CastRainStorm()
        {
            return new Storm ("rain", false, this.Title);
        }

    }
}