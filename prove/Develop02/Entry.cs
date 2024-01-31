// REMEMBER .cs!

// Class: Entry
// * _date : DateTime
// * _contents : string
// * _prompts : List <string>

// Behaviors:
// * _Display () : void

using System;

public class Entry
{
    // Create date, contents, and prompt variables in the Entry class.
    
    public string _contents;
    public string _date;
    public string _prompt;
    public List<string> _log = new List<string>();
    public string _entry;

    public string AddEntry()
    {  
        _contents = Console.ReadLine();
        _log.Add(_contents);

        DateTime today = DateTime.Now;
        _date = today.ToShortDateString();
        _log.Add(_date);

        Prompt prompt = new Prompt();
        Console.WriteLine(prompt.GivePrompt());
        _log.Add(_prompt);

        return _entry;
    }
}