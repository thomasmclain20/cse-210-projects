using System;

public class TrueOrFalse: Question
{
    public TrueOrFalse(string title, string question, string CorrectAnswer, int points): base(title, question, CorrectAnswer, points)
    {

    }
    public override void DisplayQuestion()
    {
        Console.WriteLine($"Question: {_question}");
    }

     public override bool CheckAnswer(string userAnswer)
    {
       return userAnswer.ToLower() == GetCorrectAnswer().ToLower();
    }
}