using System;

class Program
{
    static void Main(string[] args)
    {
        Journal newEntry = new Journal();
        newEntry.WriteEntry();
        newEntry.DisplayJournal();
        newEntry.SaveJournal();
        newEntry.LoadJournal();
    }
}