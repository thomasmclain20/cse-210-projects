using System;

public abstract class Question
{
    private string _title;
    private string _description;
    private string _correctAnswer;
    private int _points;

    public abstract void DisplayQuestion();

    public abstract string CheckAnswer();
}