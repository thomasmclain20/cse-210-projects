using System;
using System.Net;
using System.Collections.Generic;

public class Menu
{
    private int _points = 0;
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
                    Game game1 = CreateGame("1");
                    game1.StartGame();
                    break;

                case "2":
                    Game game2 = CreateGame("2");
                    game2.StartGame();
                    break;

                case "3":
                    Game game3 = CreateGame("3");
                    game3.StartGame();
                    break;

                case "4":
                    Game game4 = CreateGame("4");
                    game4.StartGame();
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

    public Game CreateGame(string choice)
    {
        Quiz quiz = CreateQuiz(choice);
        return new Game(quiz, 1);
    }

    public Quiz CreateQuiz(string choice)
    {
        Quiz quiz = null;
        switch (choice)
        {
            case "1":
                quiz = new Quiz("Multiple choice quiz!", 345);
                quiz.AddQuestion("Multiple Choice Question");
                break;
            case "2":
                quiz = new Quiz("Short Answer", 345);
                quiz.AddQuestion("Short Answer Question");
                break;

            case "3":
                quiz = new Quiz("True or False", 345);
                quiz.AddQuestion("T/F Question");
                break;
            
            case "4":
                quiz = new Quiz("Fill in the Blank", 345);
                quiz.AddQuestion("Fill in the blank");
                break;

        }
        return quiz;
    }
}