using System;


public abstract class JournalEntry
{
    public DateTime Date { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public abstract void Display();
    public abstract string GetSummary();
}

public class TextEntry : JournalEntry
{
    public override void Display()
    {
        Console.WriteLine($"{Date:yyy-MM-dd} - {Title}");
        Console.WriteLine(Content);
    }

    public override string GetSummary()
    {
        return $"{Title} ({Content.Length} chracters)";
    }
}