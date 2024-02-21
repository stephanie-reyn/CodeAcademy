using System;
namespace MagicInheritance
{
    class Storm
    {
        // Properties
        public string Essence
        {get; private set; }

        public bool IsStrong
        {get; private set; }

        public string Caster
        {get; private set; }

        public string Origin
        {get; private set;}

        // Conductor
        public Storm(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }

        // Method
        public string Announce()
        {
            string announcement = "";
            if (!IsStrong)
            {
                announcement = $"{Caster} from {Origin} cast a weak {Essence} storm.";
            }
            else
            {
                announcement = $"{Caster} from {Origin} cast a strong {Essence} storm."; 
            }

            return announcement; 
        }
    }
}