using System;
using System.Net;

public class Menu
{
    private int _points;
    private List<Quiz> _quizes = new List<Quiz>();

    public void menu()
    {
        bool menu = false;
        while (!menu)
        {
            Console.Clear();
            // Console.WriteLine($" Total Points {_totalPoints}");
            Console.WriteLine("Choose your quiz game");
            Console.WriteLine("1. Multiple Choice");
            Console.WriteLine("2. Short Answer");
            Console.WriteLine("3. True or False");
            Console.WriteLine("4. Fill in the blank");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    Console.WriteLine("Thanks for playing!");
                    menu = true;
                    break;

                default:
                    Console.WriteLine("not a valid option");
                    Console.ReadKey();
                    break;
            }
        }
    }

    public Game CreateGame()
    {
        return new Game();
    }

    public Quiz CreateQuiz()
    {
        return new Quiz();
    }

    public void SaveQuiz()
    {

    }

    public void LoadQuiz()
    {
        
    }
}