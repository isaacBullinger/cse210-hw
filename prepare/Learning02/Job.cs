// Class: Job
// Attributes:
// * _company : string
// * _jobTitle : string
// * _yearStart : int
// * _yearEnd : int

// Behaviors:
// * _Display() : void

using System;

public class Job
{

    // Takes variables:
    public string _jobTitle;
    public string _company;
    public int _yearStart;
    public int _yearEnd;

    // Formats variables:
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_yearStart}-{_yearEnd}");
    }
}
