using System;

class Word
{
    
    private bool _isHidden = false;
    private string _word;
    //punctuation

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    // Counts letters in the word word then puts underscores.
    public string Hide()
    {
        _isHidden = true;
        string word = "";
        for (int i = 0; i < _word.Length; i++)
        {
            word += "_";
        }
        _word = word;
        return _word;
    }

    public string Show()
    {
        string word = _word;
        return word;
    }

    public bool IsHidden()
    {
        bool isHidden = _isHidden;
        return isHidden;
    }
}
