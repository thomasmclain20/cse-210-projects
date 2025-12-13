using System;
using System.Collections.Generic;
using System.IO;

public class Quiz
{
    private string _quizTitle;
    private List<Question> _questions = new();
    private int _timer;

    public Quiz(string quizTitle, int timer)
    {
        _quizTitle = quizTitle;
        _timer = timer;

    }

    private Question CreateQuestionByType(string QuizType, string questionText, string CorrectAnswer, List<string> options = null)
    {
        switch (QuizType)
        {
            case "Multiple Choice Question":

                return new MultipleChoice("Multiple Choice Question", questionText, CorrectAnswer, 5, options);

            case "Short Answer Question":
                return new ShortAnswer("Short Answer Question", questionText, CorrectAnswer, 5);

            case "T/F Question":
                return new TrueOrFalse("T/F Question", questionText, CorrectAnswer, 5);

            case "Fill in the blank":
                return new FillInTheBlank("Fill in the blank", questionText, CorrectAnswer, 5, questionText);

            default:
                return null;
        }
    }

    public void AddQuestion(string QuizType)
    {
        string filename = "Questions.txt";
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            for (int i = 0; i < lines.Length; i++)
            {
                if (!string.IsNullOrEmpty(lines[i]) && lines[i].Contains(": "))
                {
                    var split = lines[i].Split(": ");
                    if (split[0] == QuizType)
                    {
                        if (split.Length >= 2)
                        {

                            Question question;
                            if (split.Length == 4)
                            {
                                question = CreateQuestionByType(split[0], split[1], split[2], split[3].Split("/").ToList());

                            }
                            else
                            {
                                question = CreateQuestionByType(split[0], split[1], split[2]);
                            }

                            if (question != null)
                            {
                                _questions.Add(question);
                            }
                        }
                    }
                }
            }
        }
    }

    public string GetTitle()
    {
        return _quizTitle;
    }

    public int GetQuestionCount()
    {
        return _questions.Count;
    }

    public Question GetQuestion(int index)
    {
        return _questions[index];
    }
}