using System;
using System.Security.Permissions;

class Program
{
    static void Main(string[] args)
    {   
        /* This object handles prompting the user for input.
            It will also display the scripture and the reference.
        */
        Display displayManager = new Display();

        //This object reads and writes scriptures to a file.
        FileManager fileManager = new FileManager();

        //This list holds all of the scriptures we will use
        List<Scripture> scriptures = fileManager.LoadScriptures("scriptures.txt");
        
        //this will select random scripture from scripture.txt
        Random random = new Random();

        //this holds a single scripture
        //this is where i need to figure out how to get a random scripture
        Scripture scripture = scriptures[random.Next(0, scriptures.Count)];

        //a while loop for the code to run until quit is typed in or words are all hidden
        bool running = true;

        displayManager.DisplayScripture(scripture);
        displayManager.ShowInstructions();
            

        while (running)
        {

            
            string userInput = Console.ReadLine();
            // Check for null or empty input (which happens only when user presses enter with no text input)

            switch(userInput.ToLower())
            {
                case "":
                    Console.WriteLine("Enter pressed"); //TODO Remove before turn in
                    Console.Clear();
                    scripture.HideRandomWord();
                    displayManager.DisplayScripture(scripture);
                    displayManager.ShowInstructions();
                    if (scripture.AllHidden())
                    {
                        running = false;
                    }
                    break;
                
                case "quit": //quits the program
                    running = false;
                    break;

                default:

                    break;

            }
            Console.WriteLine();
        }

    }
   
}