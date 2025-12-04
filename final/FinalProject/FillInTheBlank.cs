using System;

public class FillInTheBlank: Question
{
    public string _templateText;
    public FillInTheBlank(string templateText)
    {
        _templateText = templateText;
    }
    public override string CheckAnswer()
    {
        throw new NotImplementedException();
    }

    public override void DisplayQuestion()
    {
        throw new NotImplementedException();
    }

//Where I left off
}