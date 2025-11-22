using System;

public class Checklist : Goal
{
    private int _totalTimestoDo;
    private int _timesDone = 0;
    private int _bonusPoints;

    public Checklist(int TotalTimesToDo, int BonusPoints, int points, string title, string description) : base(title, description, points)
    {
        _totalTimestoDo = TotalTimesToDo;
        _bonusPoints = BonusPoints;

    }
    public Checklist(int TotalTimesToDo, int BonusPoints, int points, string title, string description, int timesDone) : base(title, description, points)
    {
        _totalTimestoDo = TotalTimesToDo;
        _bonusPoints = BonusPoints;
        _timesDone = timesDone;

    }
    public override int CheckOff()
    {
        if (_timesDone >= _totalTimestoDo)
        {
            return 0;
        }
        _timesDone++;
        if (_totalTimestoDo == _timesDone)
        {
            return _points + _bonusPoints;

        }
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist:{_points}:{GetTitle()}:{GetDescription()}:{_bonusPoints}:{_totalTimestoDo}:{_timesDone}";
    }

    public override string ToString()
    {
        string checkbox = _timesDone >= _totalTimestoDo ? "[X]" : "[ ]";
        return $"{checkbox} {GetTitle()} ({GetDescription()}) -- Currently completed: {_timesDone}/{_totalTimestoDo}";
    }



}