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

    public List<string> GetText()
    {
        Scripture scripture = new Scripture();
        List<string> text = scripture.GetText();

        
        return text;
    }
    
    public void Hide()
    {
        List<int> selection = new List<int>();
        int select;


        // count word then put underscores
        
    }

    // display word method
    public void Show()
    {

    }

    //check if words are hidden then choose words
    //select 3 random numbers in the list
}
