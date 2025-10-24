using System;

public class Scripture
{
    private string _scriptext;
    private string _scripref;

    public Scripture(string scriptext, string scripref)
    {
        _scriptext = scriptext;
        _scripref = scripref;
    }
    public void Display()
    {
        Console.WriteLine($"Reference: {_scripref} {_scriptext}");
    }
}
 