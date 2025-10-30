using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        //assignement for the name
        Assignment myAssignement = new Assignment("Thomas McLain", "Mathmatics");
        //this method gets the summary
        string assignementSummary = myAssignement.GetSummary();
        //Displays the summary
        Console.WriteLine(assignementSummary);

        MathAssignment math = new MathAssignment("7.5", "10-20", "Thomas McLain", "Fractions");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        WritingAssignement write = new WritingAssignement("The Odyssey", "Thomas McLain", "English Writing");
        Console.WriteLine(write.GetWritingInformation());
    }
}