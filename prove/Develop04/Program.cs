using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        bool menu = false;
        while (!menu)
        {
            Console.Clear();
            Console.WriteLine("Choose your activity");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity("This activity will help you do a quick breathing exercise", "Hope this helped you to relax", "Breathing Activity", "Set a time in seconds on how long you want to do this for");
                    breathing.Run();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity("This activity will help you reflect on things from your day", "Good job!", "Reflection Activity", "Write out things you did in your day");
                    reflection.Run();
                    break;
                
                case "3":
                    ListingActivity listing = new ListingActivity("This activity will allow you to type in reponses to prompts of things you liked in a day", "Good job this will help you in your day.", "Listing Activity", "In a set ammount of time write your responses to the prompt given");
                    listing.Run();
                    break;
                
                case "4":
                    menu = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("not a valid option");
                    Console.ReadKey();
                    break;

            }
            
        }

    }
}