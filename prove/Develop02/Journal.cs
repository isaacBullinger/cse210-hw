using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void WriteEntry()
    {
        Entry entry = new Entry();

        DateTime _today = DateTime.Now;
        entry._date = _today.ToShortDateString();

        Prompt _prompt = new Prompt();
        string _newPrompt = _prompt.GivePrompt();
        Console.WriteLine(_newPrompt);
        entry._prompt = _newPrompt;

        entry._contents = Console.ReadLine();

        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry _entry in _entries)
        {
            _entry.DisplayEntry();
        }
    }

    public void SaveJournal()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry _entry in _entries)
            {
                outputFile.WriteLine($"Date: {_entry._date} - Prompt: {_entry._prompt}\r\n{_entry._contents}");
            }
        }
    }

    public void LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}