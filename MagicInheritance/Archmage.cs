using System;

namespace MagicInheritance
{
    class Archmage : Mage
    {
        // Properties
        public new string Title
        {get; private set; }
        public new string Origin
        {get; private set; }

        // Constructor
        public Archmage (string title, string origin) : base(title, origin)
        {
            this.Title = title;
            this.Origin = origin;
        }

        // Method
        public override Storm CastRainStorm()
        {
            return new Storm ("rain", true, this.Title);
        }

        public Storm CastLightningStorm()
        {
            return new Storm ("lightning", true, this.Title);
        }

    }

}