using System;

public class FillInTheBlank: Question
{
    public string _templateText;
    public FillInTheBlank(string title, string question, string CorrectAnswer, int points, string templateText): base(title, question, CorrectAnswer, points)
    {
        _templateText = templateText;
    }
     public override bool CheckAnswer(string userAnswer)
    {
        return userAnswer.ToLower() == GetCorrectAnswer().ToLower();
    }

    public override void DisplayQuestion()
    {
        Console.WriteLine($"Question: {_question}");
    }
}