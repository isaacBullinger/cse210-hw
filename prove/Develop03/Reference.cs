using System;

public class Reference
{
    public string _book;
    public string _chapter;
    public string _verse;
    public string _end;
    
    public void DisplayReference()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}
