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
    public List<string> _log = new List<string>();
    public string _entry;

    public string AddEntry()
    {  
        DateTime today = DateTime.Now;
        _date = today.ToShortDateString();
        _log.Add(_date);

        Prompt _prompt = new Prompt();
        string _newPrompt = _prompt.GivePrompt();
        Console.WriteLine(_newPrompt);
        _log.Add(_newPrompt);

        _contents = Console.ReadLine();
        _log.Add(_contents);

        _entry = String.Format($"Date: {_date} - Prompt: {_newPrompt}\r\n{_contents}");
        Console.WriteLine(_entry);

        return _entry;
    }
}