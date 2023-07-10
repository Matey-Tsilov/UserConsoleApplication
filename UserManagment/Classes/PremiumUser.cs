using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagment.Classes
{
    public class PremiumUser : User
    {
        private List<string> bonuses = new List<string>();
        public PremiumUser(string u, string pass, string email) : base(u, pass, email)
        {
            DollersPerHour = 25;
            bonuses.Add("25$ every 3 hours");
            bonuses.Add("Coffe time evry 2 hours");
            bonuses.Add("Lunch brake - unlimited, whenever you like");
            bonuses.Add("Team building events every week");
            bonuses.Add("Life supply of food and drinks");
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
