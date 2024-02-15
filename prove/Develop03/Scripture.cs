using System;
using System.Text.Encodings.Web;

class Scripture
{
    private List<string> _texts = new List<string>();
    

    //string.split
    public List<string> GetText()
    {
        Reference reference = new Reference(5,6);
        List<string> texts = new List<string>();
        
        //string text = $"{reference.GetText()} {_proverbs5} {_proverbs6}";
        Console.WriteLine(reference.GetText());
//        Console.WriteLine(_proverbs5);
//        Console.WriteLine(_proverbs6);
//        texts.Add(_proverbs5);
//        texts.Add(_proverbs6);

        return texts;
    }

    public void HideWords()
    {

    }

    public void CompleteHide()
    {

    }
}
