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

    // public string GetText()
    //{
        
        
    //    return text;
    //}
    
    public void Hide(int count)
    {
        List<int> selection = new List<int>();
        Random randomGenerator = new Random();
        for (int i=0; i < 3; i++)
        {
            int select = randomGenerator.Next(1,count);
            selection.Add(select);
            Console.WriteLine(select);
        }


        // count word then put underscores
        
    }

    public string Show()
    {
        string word = _word;
        return word;
    }
    // display word method

    //check if words are hidden then choose words
    //select 3 random numbers in the list
}
