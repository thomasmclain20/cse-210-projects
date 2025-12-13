using System;

public class Game
{
    private Quiz _quizPlayed;
    private int _currentQuestion;

    private int _numberCorrect = 0;

    public Game (Quiz quizPlayed, int currentQuestion)
    {
        _quizPlayed = quizPlayed;
        _currentQuestion = currentQuestion;
    }

    public void StartGame()
    {
        Console.Clear();
        Console.WriteLine($"This is: {_quizPlayed.GetTitle()}");
        Console.WriteLine("Press Enter to begin...");
        Console.ReadLine();

        while (_currentQuestion <= _quizPlayed.GetQuestionCount())
        {
            //display a question
            var question = NextQuestion();
            question.DisplayQuestion();

            //this will get the user's answer
            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine();

            //checks if right or wrong and adds points if right
            if (question.CheckAnswer(userAnswer))
            {
                Console.WriteLine("Correct!");
                _numberCorrect ++;
            }

            else
            {
                Console.WriteLine($"Incorrect. The answer was: {question.GetCorrectAnswer()}");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            _currentQuestion++;
        }

        //this will show results
        DisplayResult();

    } 

    public Question NextQuestion()
    {
        Random random = new Random();
        int QuestionIndex = random.Next(0, _quizPlayed.GetQuestionCount());
       return _quizPlayed.GetQuestion(QuestionIndex);

    }



    public void DisplayResult()
    {
        Console.WriteLine($"You got: {_numberCorrect}, right.");
    }
}