using System;

public abstract class Question
{
    private string _title;
    protected string _question;
    private string _correctAnswer;
    private int _points;

    public Question(string title, string question, string CorrectAnswer, int points)
    {
        _title = title;
        _question = question;
        _points = points;
        _correctAnswer = CorrectAnswer;

    }


    public int GetPoints()
    {
        return _points;
    }

    public string GetCorrectAnswer()
    {
        return _correctAnswer;
    }

    public abstract void DisplayQuestion();

    public abstract bool CheckAnswer(string userAnswer);
}