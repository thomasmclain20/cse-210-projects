using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private string _scriptext;
    private string _scripref;
    private List<Word> _words;

    public Scripture(string scriptext, string scripref)
    {
        _scriptext = scriptext;
        _scripref = scripref;
        //need to split up the words and make multiple classes
        _words = new List<Word>();
        SplitText();

    }

    //this function splilt the words into different objects
    public void SplitText()
    {
        var Split = _scriptext.Split(' ');
        foreach (var word in Split)
        {
            _words.Add(new Word(word, false));
        }
    }

    //This method displays the scripture
    public void Display()
    {
        Console.WriteLine($"Reference: {_scripref} {_scriptext}");
    }

    //this method returns the scripture refference
    public string Reference()
    {
        return _scripref;
    }

    public string Text()
    {
        return String.Join(' ', _words.Select(word => word.Display()));
    }


    //this is a method to hide random words
    public void HideRandomWord()
    {
        //were gonna itterate through every word in the list and randomly call the hide method on a word
        Random random = new Random();
        int counter = 0; // Random position in the list
        int index = 0; // Position of the word in the list

        foreach (Word word in _words)
        {
            //Generate a random integer between 0and the total number of words
            counter = random.Next(0, _words.Count);

            if (index == counter)
            {
                word.Hide();//Hide this word

            }

            //increment our index
            index++;
        }



        //after we hid the word were gonna replace the characters with the same number of underlines to represent a blank space to the user


        //and then were going to store the words in a scripture and then return it

        //after all the words are hidden the program should end
    }
    public bool AllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }

        }

        return true;
    }

    //This code will randomize which words are hidden
    // public Word Randomize()
    // {

    // }
}
