using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace DatingApp
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;


        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country; 
            this.pronouns = pronouns;
        }

        public Profile(string name, int age) : this(name, age, "", "")
        {

        }

        public string Name
        {
            get { return name;}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                name = value; 
            }
        }

        public int Age
        {
            get { return age;}
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("You must be at least 18");
                }
                age = value;
            }
        }

        public string City
        {
            get {return city;}
            set {city = value;}
        }

        public string Country
        {
            get {return country;}
            set {country = value;}
        }

        public string Pronouns
        {
            get {return pronouns;}
            set {pronouns = value;}
        }

        public string[] Hobbies
        {
            get {return hobbies;}
            set {hobbies = value;}
        }

        public string ViewProfile()
        {
            string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}\n";
            if (hobbies != null && hobbies.Length > 0)
            {
                bio += "Hobbies: ";
                foreach (string hobby in hobbies)
                {
                    bio += $"{hobby},\n";
                }
            }
            return bio;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }



    }
}