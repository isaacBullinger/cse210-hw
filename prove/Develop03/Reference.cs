using System;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private int _end;
    
    public void DisplayReference();
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}
