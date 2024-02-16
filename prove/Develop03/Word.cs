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

    public void Hide()
    {
        _isHidden = true;
        foreach (char letter in _word)
        {
            _word.Replace(letter,'_');
        }
    }

    // count word then put underscores
    public string Show()
    {
        string word = _word;
        return word;
    }

    public void IsHidden()
    {
        if (_isHidden == true)
        {
            foreach (char letter in _word)
            {
                _word.Replace(letter,'_');
            }
        }
    }

    // display word method

    //check if words are hidden then choose words
    //select 3 random numbers in the list
}
