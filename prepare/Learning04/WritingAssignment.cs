using System;

public class WritingAssignement : Assignment
{
    private string _title; 

    public WritingAssignement(string title, string studentName, string topic): base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{base.GetSummary()}\n{_title}";
    }
}