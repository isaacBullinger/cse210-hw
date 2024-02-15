using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _end;

    public Reference(int verse)
    {
        _book = "Proverbs";
        _chapter = 3; 
        _verse = verse;
    }

    public Reference(int verse, int end)
    {
        _book = "Proverbs";
        _chapter = 3;
        _verse = verse;
        _end = end;
    }

    public string GetText()
    {
        // Check if there is and end.
        string text = $"{_book} {_chapter}:{_verse} {_end}";
        return text;
    }

    public string GetMultiText()
    {
        string text = $"{_book} {_chapter}:{_verse}-{_end}";
        return text;
    }
}
