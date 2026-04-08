using System;

public class UI
{
    public static void ShowHeader()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n====================================");
        Console.WriteLine("  CYBERSECURITY AWARENESS BOT");
        Console.WriteLine("====================================\n");
        Console.ResetColor();
    }

    public static void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
   ____      _                      _   _             
  / ___|   _| |__   ___ _ __ ___  | | | | ___  _ __  
 | |  | | | | '_ \ / _ \ '__/ _ \ | |_| |/ _ \| '_ \ 
 | |__| |_| | |_) |  __/ | |  __/ |  _  | (_) | | | |
  \____\__, |_.__/ \___|_|  \___| |_| |_|\___/|_| |_|
       |___/                                          
");

        Console.ResetColor();
    }

    public static string GetUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty. Please try again.");
            name = Console.ReadLine();
        }

        return name;
    }
}