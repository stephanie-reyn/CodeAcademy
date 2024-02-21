using System;

namespace AppInterface
{
    class PasswordManager : IDisplayable, IResetable
    {
        // Property
        private string password
        { get; set; }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 8)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Password must be at least 8 characters long.");
                }
            }
        }

        public bool Hidden
        { get; private set; }

        public string HeaderSymbol => "-";

        // Constructor
        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        // Method
        public void Display()
        {
            Console.WriteLine("Password");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(HeaderSymbol);
            }
            Console.WriteLine("");
            if (Hidden = false)
            {
                Console.WriteLine(Password);
            }
            else
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("");
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == Password)
            {
                Password = newPassword;
                return true;
            }
            else
            {
                Console.WriteLine("Failed to change password. Old password does not match.");
                return false;
            }
        }
    }
}