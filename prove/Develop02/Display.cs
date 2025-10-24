using System;
using System.Data;

public class Display
{
    private List<string> prompts = new List<string>
    {
        "What did I do today?",
        "Who did I interact with?",
        "How did I see the hand of the Lord today?",
        "What thoughts did I have today?",

    };
     public void ShowMainMenu()
    {
        Console.WriteLine("\n=== My Journal ===");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. My entries");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }

    public void ShowWritingPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nHere's a prompt:");
        Console.WriteLine($" {prompt}");
        Console.WriteLine(new string('-', 50));
    }

    public void ShowSuccess(string message)
    {
        Console.WriteLine($"Success: {message}");
    }

    public void ShowError(string message)
    {
        Console.WriteLine($"Error: {message}");
    }

    public void ShowGoodbyeMessage()
    {
        Console.WriteLine("Goodbye");
    }
}

