using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.Classes;
using UserManagment.Constants;

namespace UserManagment.Utilities
{
    public class Utilities
    { 

        internal static void CreateUser(List<User> users)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~~~~~~User data~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What user type would you choose?");
            Console.Write("1. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Regular User");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("2. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Upgraded User");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("3. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Premium User");
            Console.ForegroundColor = ConsoleColor.Cyan;


            Console.Write("Your selection: ");
            Console.ForegroundColor = ConsoleColor.White;
            string userType = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nUsername: ");
            Console.ForegroundColor = ConsoleColor.White;
            string username = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Email Address: ");
            Console.ForegroundColor = ConsoleColor.White;
            string email = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Password: ");
            Console.ForegroundColor = ConsoleColor.White;
            string password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            User user = null;

            switch (userType)
            {
                case "1":
                    user = new User(username, email, password);
                    break;
                case "2":
                    user = new UpgradedUser(username, email, password); 
                    break;
                case "3":
                    user = new PremiumUser(username, email, password);
                    break;
                case "4": break;
                default:
                    Console.WriteLine("There is no such user type, sorry! Try again please!");
                    return;

            }

            users.Add(user);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("New user was created!\n\n");
        }

        internal static void GenerateInfo(List<User> users)
        {
            foreach (User u in users)
            {
                u.Display();
            }
        }

        internal static void CheckIfDirectoryExists()
        {
            if (File.Exists(Constants.Constants.PATH))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An existing file with populated Users data already exists!\n");
                Console.ResetColor();
            }
            else
            {
                Directory.CreateDirectory(Constants.Constants.DIRECTORY);
                File.Create(Constants.Constants.PATH).Close();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Directory is ready for saving users!");
                Console.ResetColor();
            }
               
        }

        internal static void SaveEmployees(List<User> users) 
        {
            if (users.Count == 0)
            {
                Console.WriteLine("Sorry, you haven't created any user records\n");
                return;
            }
            StringBuilder sb = new StringBuilder();
            foreach(User u in users)
            {
                sb.Append($"Type:{GetUserType(u)};");
                sb.Append($"Username:{u.Username};");
                sb.Append($"Email:{u.Email};");
                sb.Append($"Password:{u.Password};");
                sb.Append($"HourlyRate:{u.DollersPerHour};");
                sb.Append(Environment.NewLine);
            }

            File.WriteAllText(Constants.Constants.PATH, sb.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Employees saved successefuly!\n\n");
            Console.ResetColor();


        }

        internal static void LoadUsers(string[] users)
        {
            if (users.Length == 0)
            {
                Console.WriteLine("Sorry, there aren't any records to be loaded! Create some.");
                return;
            }

            foreach (string userLine in users)
            {
                string[] userSplits = userLine.Split(';');

                string[] typeArr = userSplits[0].Split(':');
                string type = typeArr[1];
                string[] unArr = userSplits[1].Split(':');
                string username = unArr[1];
                string[] emailArr = userSplits[2].Split(':');
                string email = emailArr[1];
                string[] passArr = userSplits[3].Split(':');
                string password = passArr[1];

                User curUser = null;

                switch (type)
                {
                    case "1":
                        curUser = new User(username, email, password);
                        break;
                    case "2":
                        curUser = new UpgradedUser(username, email, password);
                        break;
                    case "3":
                        curUser = new PremiumUser(username, email, password);
                        break;

                }
                curUser.Display();
            }

        }

        internal static void DeleteUser(string[] usersLine, string uName)
        {
         
            foreach (string user in usersLine)
            {
                string[] userChuncks = user.Split(";");
                string name = userChuncks[1].Split(":")[1].ToLower();

                if (name == uName)
                {
                    string hello = usersLine.Where(u => u.Contains(name) == false).ToString();
                    File.WriteAllText(Constants.Constants.PATH, hello);
                }else
                {
                    Console.WriteLine("There is no such User! Please try again!");
                    return;
                }

            }

            

            
        }

        private static string GetUserType(User user)
        {
           if (user is PremiumUser)
            {
                return "3";
            }else if(user is UpgradedUser)
            {
                return "2";
            }else if(user is User)
            {
                return "1";
            }else
            {
                return "User type - non-existend";
            }


        }


    }
}
