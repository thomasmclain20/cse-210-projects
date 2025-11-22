using System;
//this is the parent class
public abstract class Goal
{
    private string _title;
    private string _description;
    protected int _points;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    protected string GetTitle()
    {
        return _title;
    }

    protected string GetDescription()
    {
        return _description;
    }

    public abstract int CheckOff();

    public abstract string GetStringRepresentation();
    public abstract override string ToString();
}