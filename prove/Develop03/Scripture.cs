using System;

class Scripture
{
    private Reference _reference;
    
    private string _proverbs5 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
    private string _proverbs6 = "In all thy ways acknowledge him, and he shall direct thy paths.";

    //string.split
    public string GetText()
    {
        Reference reference = new Reference(5,6);
        string text = $"{reference.GetText()} {_proverbs5} {_proverbs6}";

        return text;
    }
}
