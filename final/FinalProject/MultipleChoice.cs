using System;

public class MultipleChoice: Question
{
    private List<string> _options = new();

    public override void DisplayQuestion()
    {

    }

    public override string CheckAnswer()
    {
        return "";
    }
}