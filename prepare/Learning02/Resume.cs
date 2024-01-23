// REMEMBER .cs!

// Class: Resume
// * _name : string
// * _jobs : List<Job>

// Behaviors:
// * _Display () : void

using System;

public class Resume
{
    // Create name and job list:
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Writes name and jobs strings, then iterates through list of jobs.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}