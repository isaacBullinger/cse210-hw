// REMEMBER .cs!

// Class: Entry
// * _date : DateTime
// * _contents : string
// * _prompts : List <string>

// Behaviors:
// * AddEntry () : string

using System;

public class Entry
{
    // Create date, contents, and prompt variables in the Entry class.
    
    public string _contents;
    public string _date;
    public string _prompt;
    public Entry entry;

    public void DisplayEntry()
    {  
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\r\n{_contents}\r\n");
    }
}