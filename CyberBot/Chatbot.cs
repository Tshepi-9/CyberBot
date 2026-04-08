using System;

public class Chatbot
{
    public static void Respond(string input, string name)
    {
        input = input.ToLower();

        if (input.Contains("how are you"))
        {
            Console.WriteLine($"Bot: I'm doing well, {name}! Staying secure online 😊");
        }
        else if (input.Contains("purpose"))
        {
            Console.WriteLine("Bot: I help you learn how to stay safe from cyber threats.");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Bot: Phishing is when attackers trick you into giving personal info through fake emails or messages.");
        }
        else if (input.Contains("password"))
        {
            Console.WriteLine("Bot: Use strong passwords with letters, numbers, and symbols.");
        }
        else if (input.Contains("browsing"))
        {
            Console.WriteLine("Bot: Only visit trusted websites and avoid suspicious links.");
        }
        else if (input.Contains("what can i ask"))
        {
            Console.WriteLine("Bot: You can ask me about passwords, phishing, safe browsing, and cyber safety tips.");
        }
        else
        {
            Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
        }
    }
}