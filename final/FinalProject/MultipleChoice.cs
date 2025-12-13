using System;
using System.Collections.Generic;

public class MultipleChoice: Question
{
    private List<string> _options = new();

    public MultipleChoice(string title, string description, string CorrectAnswer, int points, List<string> options): base(title, description, CorrectAnswer, points)
    {
        _options = options;
    }



    public override void DisplayQuestion()
    {
        Console.WriteLine($"Question: {_question}");
        for (int i = 0; i < _options.Count; i++)
        {
            Console.WriteLine($"{_options[i]}");
        }

    }

    public override bool CheckAnswer(string userAnswer)
    {
        return userAnswer.ToLower() == GetCorrectAnswer().ToLower();
    }
}