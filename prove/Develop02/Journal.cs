// Class: Journal
// * _entries : List<Entry>

// Behaviors:
// * WriteEntry() : void
// * DisplayJournal() : void
// * SaveJournal() : void
// * LoadJournal : void

using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

// This method generates the current date, a prompt,
// and allows the user to input the contents of their entry.

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

// This method checks the journal entries,
// If populated it will iteratively display entries. 
// If not populated an error message is given.

    public void DisplayJournal()
    {
        // Creativity & Exceeding Core Requirements:
        // If there are no entries, this tells the user to load a file.

        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found! Please load file.\r\n");
        }

        else
        {
            foreach (Entry _entry in _entries)
            {
                _entry.DisplayEntry();
            }
        }
    }

// This method asks the user to name the file they wish to save to.
// Then it formats and saves the entries to a file for later retrieval.

    public void SaveJournal()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        Console.WriteLine($"Saving {fileName}...\r\n");

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry _entry in _entries)
            {
                outputFile.WriteLine($"{_entry._date}~{_entry._prompt}~{_entry._contents}");
            }
        }
    }

// This method allows the user to load a specified journal from a previously saved file.
    public void LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        Console.WriteLine($"Loading {fileName}...\r\n");

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Entry _entry = new Entry();

            string[] parts = line.Split("~");

            _entry._date = parts[0];
            _entry._prompt = parts[1];
            _entry._contents = parts[2];

            _entries.Add(_entry);
        }
    }
}