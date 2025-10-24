using System;

public class Entry
{
    private string _date;
    private string _title;
    private string _content;
    
    //constructor for the Entry class
    public Entry(string date, string title, string content)
    {
        _date = date;
        _title = title;
        _content = content;
    }

    //property to access the Date
    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }

    //property to access the title
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    //property to access the Content
    public string Content
    {
        get { return _content; }
        set { _content = value; }
    }

    //public method to display entries
    public void PrintEntry ()
    {
        Console.WriteLine($" {_date}");
        Console.WriteLine($"\n");
        Console.WriteLine($" {_title}");
        Console.WriteLine($"\n");
        Console.WriteLine($" {_content}");
    }

}