
using System.Security.Cryptography.X509Certificates;
using UserManagment.Classes;
using UserManagment.Constants;
using UserManagment.Utilities;

string userType;
string selection;
List<User> users = new List<User>();

do
{
    Utilities.CheckIfDirectoryExists();
    Console.WriteLine($"You have {users.Count} record(s) in program memory");

    if (File.Exists(Constants.PATH))
    {
        string[] textFile = File.ReadAllLines(Constants.PATH);
        Console.WriteLine($"You have {textFile.Length} record(s) in cache memory");
    }
    else
    {
        Console.WriteLine($"You have 0 record(s) in cache memory");
    }

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("~~~~~~~~~~Select an action~~~~~~~~~~");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("What would you like to do?");
    Console.Write("1. ");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Register User");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("2. ");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("View Users in Program Memory");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("3. ");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Save Users in Cache Memory");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("4. ");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Load Users From Cache Memory");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("5. ");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Quit Application");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Your selection: ");

    selection = Console.ReadLine();
    Console.Write('\n');

    switch (selection)
    {
        case "1":
            Utilities.CreateUser(users);
            break;
        case "2":
            Utilities.GenerateInfo(users);
            break;
        case "3":
            Utilities.SaveEmployees(users);
            break;
        case "4": 
            Utilities.LoadUsers(users);
            break;
        case "5": break;
            default: Console.WriteLine("The selection was invalid. Try again!"); break;



    }



} while (selection != "5");
