using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DisplayManager displayManager = new DisplayManager();
        FileManager fileManager = new FileManager();
        List<JournalEntry> entries = new List<JournalEntry>();
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

                    TextEntry newEntry = new TextEntry();
                    newEntry.Date = DateTime.Now;
                    newEntry.Title = title;
                    newEntry.Content = content;

                    entries.Add(newEntry);
                    displayManager.ShowSuccess("Entry added");
                    break;

                case "2": //view entries
                    Console.WriteLine("\n=== Journal Entires ===");
                    foreach (var entry in entries)
                    {
                        entry.Display();
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