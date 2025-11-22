using System;

public class Eternal : Goal
{
    public Eternal(int points, string title, string description) : base(title, description, points) { }

    public override int CheckOff()
    {
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal:{_points}:{GetTitle()}:{GetDescription()}";
    }

    public override string ToString()
    {
        return $"[ ] {GetTitle()} ({GetDescription()})";
    }
}