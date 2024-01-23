using System;

class Program
{
    static void Main(string[] args)
    {

        // Creates job variables:
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._yearStart = 2016;
        job1._yearEnd = 2018;
        
        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";
        job2._yearStart = 2020;
        job2._yearEnd = 2021;
        
        // Adds a name to the resume:
        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
        
        // Adds jobs to the resume:
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Calls on the Resume Display function to display jobs:
        resume1.Display();
    }
}