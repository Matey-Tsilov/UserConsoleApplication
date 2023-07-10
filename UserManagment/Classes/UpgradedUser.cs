using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagment.Classes
{
    public class UpgradedUser : User
    {
        private List<string> bonuses = new List<string>();
        public UpgradedUser(string u, string pass, string email) : base(u, pass, email) { 
        DollersPerHour = 10;
            bonuses.Add("10$ every 5 hours");
            bonuses.Add("Coffe time every 4 hours");
            bonuses.Add("Lunch brake once a day");
        }

        public override void Display()
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
            Console.WriteLine($"{DollersPerHour}\n");
            Console.WriteLine($"If you are worried about the bonuses, here they are:");
            foreach (string bonus in bonuses)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("---");
                Console.ResetColor();
                Console.WriteLine(bonus);

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------\n\n");
            Console.ResetColor();

   
        }


    }
}
