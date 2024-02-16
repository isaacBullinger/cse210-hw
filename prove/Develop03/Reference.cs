using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _end = 0;

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
        string text;
        // Check if there is and end.
        if (_end ==0)
        {
            text = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            text = $"{_book} {_chapter}:{_verse}-{_end}";
        }
        return text;
    }

    public int GetEnd()
    {
        int end = _end;
        return end;
    }
}
