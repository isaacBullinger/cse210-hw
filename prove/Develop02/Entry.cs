// Class: Entry
// * _date : DateTime
// * _contents : string
// * _prompt : string

// Behaviors:
// * DisplayEntry () : string

using System;

public class Entry
{
    // Creates date, contents, and prompt variables in the Entry class.
    
    public string _contents;
    public string _date;
    public string _prompt;

    public void DisplayEntry()
    {  
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\r\n{_contents}\r\n");
    }
}
