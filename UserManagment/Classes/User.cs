using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagment.Classes
{
    internal class User
    {
        private string _username;
        private string _password;
        private string _email;
        private int _dollersPerHour;

        public User(string u, string email, string pass) {
            Username = u;
            Email = email;
            Password = pass;
            DollersPerHour = 5;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int DollersPerHour { get; protected set; }

        public virtual void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------User Info------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"User: ");
            Console.ResetColor();
            Console.WriteLine($"{Username}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Email Address: ");
            Console.ResetColor();
            Console.WriteLine($"{Email}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Password: ");
            Console.ResetColor();
            Console.WriteLine($"{Password}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Wage: ");
            Console.ResetColor();
            Console.WriteLine($"{DollersPerHour}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------\n\n");
            Console.ResetColor();


        }
    }
}
