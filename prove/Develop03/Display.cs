using System;
using System.Data;

//this class will handle the input and output on the console
public class Display
{
    
    private List<string> prompts = new List<string>
    {
        "Press Enter to hide random words",
        "Type quit to exit program",
    };

    //this method displays the scripture
    public void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.Reference());
        Console.WriteLine(scripture.Text());
    }
     public void ShowInstructions()
    {   
        Console.Write("\nPress Enter to hide random words or type quit to exit");
    }
    

    public void ShowGoodbyeMessage()
    {
        Console.WriteLine("Goodbye");
    }
}

