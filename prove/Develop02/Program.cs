using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Display displayManager = new Display();
        FileManager fileManager = new FileManager();
        List<Entry> entries = new List<Entry>();
        bool running = true;

        while (running)
        {
            displayManager.ShowMainMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    displayManager.ShowWritingPrompt();
                    Console.Write("Entry title: ");
                    string title = Console.ReadLine();
                    Console.Write("Your thoughts: ");
                    string content = Console.ReadLine();
                    
                    //this gets the current date and time in a string
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    Entry newEntry = new Entry(dateText, title, content);

                    entries.Add(newEntry);
                    displayManager.ShowSuccess("Entry added");
                    break;

                case "2": //view entries
                    Console.WriteLine("\n=== Journal Entires ===");
                    foreach (var entry in entries)
                    {
                        entry.PrintEntry();
                    }
                    break;
                
                case "3": // Save
                    Console.Write("Enter filename to save: ");
                    string saveFileName = Console.ReadLine();
                    fileManager.SaveEntries(entries, saveFileName);
                    displayManager.ShowSuccess("Journal saved!");
                    break;
                
                case "4": //Load
                    Console.Write("Enter filename to load: ");
                    string loadFileName = Console.ReadLine();
                    entries = fileManager.LoadEntries(loadFileName);
                    displayManager.ShowSuccess("Journal loaded");
                    break;

                case "5": // quit
                    displayManager.ShowGoodbyeMessage();
                    running = false;
                    break;
                
                default:
                    displayManager.ShowError("Invalid Choice");
                    break;
            }
        }
    }
}