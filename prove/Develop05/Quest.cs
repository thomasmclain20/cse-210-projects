using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
public class Quest
{
    private int _totalPoints = 0;
    private List<Goal> _goals = new List<Goal>();


    public void Menu()
    {
        bool menu = false;
        while (!menu)
        {
            Console.Clear();
            Console.WriteLine($" Total Points {_totalPoints}");
            Console.WriteLine("Set your goals");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoals();
                    Console.ReadKey();
                    break;

                case "3":
                    SaveGoals();
                    Console.ReadKey();
                    break;

                case "4":
                    LoadGoals();
                    Console.ReadKey();
                    break;

                case "5":
                    RecordEvent();
                    Console.ReadKey();
                    break;

                case "6":
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

    public bool CreateGoal()
    {
        bool menu = false;
        while (!menu)
        {
            Console.Clear();
            Console.WriteLine("What type of Goal do you have?");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("How many points is the goal worth?");
                    string points = Console.ReadLine();
                    Console.WriteLine("What is the title of the goal?");
                    string title = Console.ReadLine();
                    Console.WriteLine("Do you want a description?");
                    string description = Console.ReadLine();
                    Simple simple = new Simple(int.Parse(points), title, description);
                    _goals.Add(simple);
                    menu = true;
                    break;

                case "2":
                    Console.WriteLine("How many points is the goal worth?");
                    string eternalPoints = Console.ReadLine();
                    Console.WriteLine("What is the title of the goal?");
                    string eternalTitle = Console.ReadLine();
                    Console.WriteLine("Do you want a description?");
                    string eternalDescription = Console.ReadLine();
                    Eternal eternal = new Eternal(int.Parse(eternalPoints), eternalTitle, eternalDescription);
                    _goals.Add(eternal);
                    menu = true;
                    break;

                case "3":
                    Console.WriteLine("How many points is the goal worth?");
                    string checklistPoints = Console.ReadLine();
                    Console.WriteLine("What is the title of the goal?");
                    string checklistTitle = Console.ReadLine();
                    Console.WriteLine("Do you want a description?");
                    string checklistDescription = Console.ReadLine();
                    Console.WriteLine("How many times must this goal be completed?");
                    string totalTimes = Console.ReadLine();
                    Console.WriteLine("How many bounus points for completing all the goals?");
                    string bonusPoints = Console.ReadLine();
                    Checklist checklist = new Checklist(int.Parse(totalTimes), int.Parse(bonusPoints), int.Parse(checklistPoints), checklistTitle, checklistDescription);
                    _goals.Add(checklist);
                    menu = true;
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    Console.ReadKey();
                    break;
            }

        }
        return true;
    }
    public void ListGoals()
    {
        Console.Clear();
        Console.WriteLine($"You have {_totalPoints} points.");
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]}");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _totalPoints = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
               var split = lines[i].Split(':');
               switch(split[0])
                {
                    case "Simple":
                        _goals.Add(new Simple(int.Parse(split[1]), split[2], split[3], int.Parse(split[4])));
                        break;

                    case "Eternal":
                        _goals.Add(new Eternal(int.Parse(split[1]), split[2], split[3]));
                        break;

                    case "Checklist": 
                        _goals.Add(new Checklist(int.Parse(split[5]),int.Parse(split[4]),int.Parse(split[1]), split[2], split[3]));
                        break;
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }

     public void RecordEvent()
  {
      Console.Clear();
      ListGoals();
      Console.WriteLine("Which goal did you accomplish?");
      string choice = Console.ReadLine();

      int goalIndex = int.Parse(choice) - 1;

      if (goalIndex >= 0 && goalIndex < _goals.Count)
      {
          int pointsEarned = _goals[goalIndex].CheckOff();
          _totalPoints += pointsEarned;
          if (pointsEarned > 0)
          {
            ShowCelebration();
          }
          Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
          Console.WriteLine($"You now have {_totalPoints} points.");
      }
      else
      {
          Console.WriteLine("Invalid goal selection!");
      }
  }

  //this method makes a simple celebration animation whenever i mark a goal as complete
  private void ShowCelebration()
  {
    Console.Clear();
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Congratulations!");
        Console.WriteLine("Good Job");
        Console.WriteLine("You get a cookie!");
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("Fantastic!");
        Console.WriteLine("Well Done!");
        Console.WriteLine("Keep Going!");
        Thread.Sleep(1000);
        Console.Clear();
    }
  }
}