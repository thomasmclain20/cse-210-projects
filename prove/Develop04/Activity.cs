using System;

public class Activity
{
    protected string _startMessage;
    protected string _endMessage;
    protected int _seconds;
    protected string _title;
    protected string _instructions;

    public Activity(string startMessage, string endMessage, string title, string instructions)
    {
        _startMessage = startMessage;
        _endMessage = endMessage;
        _title = title;
        _instructions = instructions;
    }


        public void AskDuration()
    {   
        Console.WriteLine(_startMessage);
        Console.Write("How long do you want the activity to last for? ");
        string duration = Console.ReadLine();

        _seconds = int.Parse(duration);

    }

    public void CountDown()
    {
        //this will be the countdown to start
        for(int i = 5; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(500);
        }
        Console.WriteLine();

    }

    public void Animation()
    {
        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).Seconds <= 5)
        {
            Console.Write("+");

            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
        }
    }

}