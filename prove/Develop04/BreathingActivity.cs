using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string startMessage, string endMessage, string title, string instructions) : base(startMessage, endMessage, title, instructions)
    {

    }

    //This code will improve the animation to mimic natural breathing
    static void BreatheIn(int seconds)
    {
        Console.Write("Breathe in...");
        for(int i = seconds; i > 0; i--)
        {
            Console.Write($" {i}");
            Thread.Sleep(800);
            Console.Write("\b \b\b \b");
        }
        Console.WriteLine(" 0");
    }

    static void BreatheOut(int seconds)
    {
        Console.Write("Breathe out...");

        for (int i = seconds; i > 0; i--)
        {
            Console.Write($" {i}");
            Thread.Sleep(800);
            Console.Write("\b \b\b \b");
        }
        Console.WriteLine(" 0");
    }

    public void Run()
    {
        AskDuration(); //time between each breath
        Console.WriteLine("Get Ready");
        Animation();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _seconds)
        {
            BreatheIn(4);
            BreatheOut(6);
            Console.WriteLine();

        }
        Console.WriteLine(_endMessage);
        Animation();
    }
}