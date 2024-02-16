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

    // count word then put underscores
    public string Show()
    {
        string word = _word;
        return word;
    }

//    public string IsHidden()
//    {
//        if (_isHidden == true)
//        {
//            foreach (char letter in _word)
//            {
//                Console.Write("_");
//            }
//        }
//        return _word;
//    }

//    public void GetText()
//    {

//    }

    // display word method

    //check if words are hidden then choose words
    //select 3 random numbers in the list
}
