using System;
using System.Numerics;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;


    public ReflectionActivity(string startMessage, string endMessage, string title, string instructions) : base(startMessage, endMessage, title, instructions)
    {
        _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?" };

    }



    public string Response()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count - 1);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }

    public void Reflect()
    {
        //prompt shows up
        Console.WriteLine("Think about this question:");
        Console.WriteLine($"--- {Response()} ---");
        Console.WriteLine("When you have your answer hit enter.");
        Console.ReadLine(); //Wait for user
        Console.WriteLine("Now think about the following questions related to your answer");
        Console.WriteLine("Begin in t-minus");
        //
        CountDown();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _seconds)
        {
            Console.WriteLine(GetRandomQuestion());
            Animation(); //pause
            Console.WriteLine();

        }
    }


    public void Run()
    {
        AskDuration();
        Console.WriteLine("Ready?");
        Animation();

        Reflect(); 

        Console.WriteLine(_endMessage);
        Animation();
        
    }

}
