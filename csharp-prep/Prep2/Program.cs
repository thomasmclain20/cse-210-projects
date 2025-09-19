using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage?");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
    
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You are a: {letter} student");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed, study hard and try again.");
        }
    
    }
}