using System;

public class Simple : Goal
{
    private int _totalTimestoDo = 1;
    private int _timesDone = 0;
    public Simple(int points, string title, string description) : base(title, description, points) { }
    public Simple(int points, string title, string description, int timesDone) : base(title, description, points) {_timesDone=timesDone;}

    public override int CheckOff()
    {
        if (_timesDone >= _totalTimestoDo)
        {
            return 0;
        }
        _timesDone++;
        if (_totalTimestoDo == _timesDone)
        {
            return _points;

        }
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple:{_points} : {GetTitle()} : {GetDescription()} : {_timesDone}";
    }

    public override string ToString()
    {
        string checkbox = _timesDone >= 1 ? "[X]" : "[ ]";
        return $"{checkbox} {GetTitle()} ({GetDescription()})";
    }
}