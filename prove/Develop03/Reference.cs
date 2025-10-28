using System;

public class Reference
{
    private string _chapter;
    private string _book;
    private int _startverse;
    private int _endverse;

    public Reference (string chapter, string book, int startverse, int endverse)
    {
        _chapter = chapter;
        _book = book;
        _startverse = startverse;
        _endverse = endverse;
    }

    //This function retrieves references for a single scripture
    public Reference GetReference()
    {
        return null; //TODO return the reference once we get it
    }


}