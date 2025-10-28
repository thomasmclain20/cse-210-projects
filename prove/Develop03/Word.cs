using System;

public class Word
{
    private string _word;
    private bool _ishidden;

    public Word(string word, bool ishidden)
    {
        _word = word;
        _ishidden = ishidden;   
    }

    //This method hides the word
    public void Hide()
    {
        _ishidden = true;
        int length = _word.Length;
        string newWord = new string('_', length);
        _word = newWord;
    }

    public bool IsHidden()
    {
        return _ishidden;
    }

    public string Display()
    {
        if(_ishidden)
        {
            return new string('_',_word.Length);
        }

        else
        {
            return _word;
        }
    }
}