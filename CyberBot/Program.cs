using System;

class Program
{
    static void Main(string[] args)
    {
        Audio.PlayGreeting();
        UI.ShowLogo();

        UI.ShowHeader();

        string name = UI.GetUserName();

        Console.WriteLine($"\nWelcome {name}! I am your Cybersecurity Awareness Bot.");
        Console.WriteLine("Ask me anything about cybersecurity.\n");

        while (true)
        {
            Console.Write("\nYou: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Bot: Please enter a valid message.");
                continue;
            }

            Chatbot.Respond(input, name);
        }
    }
}