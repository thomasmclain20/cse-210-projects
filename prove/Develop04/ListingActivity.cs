using System;
using System.Collections.Generic;

public class ListingActivity :Activity
{
    private List<string> _prompts;

    public ListingActivity(string startMessage, string endMessage, string title, string instructions): base(startMessage, endMessage, title, instructions)
    {
        _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }
    

    public void WriteList()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.Write("Begin in: ");
        Console.WriteLine($"--- {_prompts[index]} ---");

        CountDown();
        
        //Start the listing before time runs out
        List<string> responses = CollectResponses();

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        
    }

    //This will be the collectreponses method

    private List<string> CollectResponses()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;

        Console.WriteLine("Start listing now!");
        
        while ((DateTime.Now - startTime).TotalSeconds < _seconds)
        {
            Console.Write("> ");

            double remainingTime = _seconds - (DateTime.Now - startTime).TotalSeconds;
            if(remainingTime <= 0) break;

            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                responses.Add(response);
            }
            
        }
        return responses;
    }

    public void Run()
    {
        AskDuration(); //gets seconds from activity
        Console.WriteLine("Get ready.");
        Animation();
        WriteList();
        Console.WriteLine(_endMessage);
        Animation();
    }
}