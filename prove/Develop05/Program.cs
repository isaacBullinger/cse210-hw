using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int menu;
        int points = 0;
        List<Goal> goals = new List<Goal>();
        bool quit = false;

        string Filename()
        {
            Console.WriteLine("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            return filename;
        }

        while(quit == false)
        {
            Console.WriteLine($"You have {points} points.");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                menu = int.Parse(Console.ReadLine());

                if (menu == 1)
                {
                    Simple simple = new Simple();
                    goals.Add(simple);
                }

                if (menu == 2)
                {
                    Eternal eternal = new Eternal();
                    goals.Add(eternal);
                }

                if (menu == 3)
                {
                    Checklist checklist = new Checklist();
                    goals.Add(checklist);
                }
                menu = 0;
            }

            if (menu == 2)
            {
                int number = 1;
                string check;

                Console.WriteLine("The goals are:");
                foreach (Goal goal in goals)
                {
                    if (goal.IsComplete() == true)
                    {
                        check = "X";
                    }

                    else
                    {
                        check = " ";
                    }

                    Console.WriteLine($"{number}. [{check}] {goal.GetName()} {goal.GetDescription()}");

                    number = number + 1;
                }
            }

            if (menu == 3)
            {

                string filename = Filename();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(points);

                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.RecordGoal());
                    }
                }
                menu = 0;
            }

            if (menu == 4)
            {
                string filename = Filename();
                string[] lines = System.IO.File.ReadAllLines(filename);


                foreach (string line in lines)
                {
                    string[] parts = line.Split("~");

                    if (parts.Length == 1)
                    {
                        points = int.Parse(parts[0]);
                    }
                    
                    if (parts[0] == "SimpleGoal:")
                    {
                        Simple simple = new Simple();
                        simple.SetName(parts[1]);
                        simple.SetDescription(parts[2]);
                        simple.SetPoints(parts[3]);
                        goals.Add(simple);
                    }

                    if (parts[0] == "EternalGoal:")
                    {
                        Eternal eternal = new Eternal();
                        eternal.SetName(parts[1]);
                        eternal.SetDescription(parts[2]);
                        eternal.SetPoints(parts[3]);
                        goals.Add(eternal);
                    }

                    if (parts[0] == "ChecklistGoal:")
                    {
                        Checklist checklist = new Checklist();
                        checklist.SetName(parts[1]);
                        checklist.SetDescription(parts[2]);
                        checklist.SetPoints(parts[3]);
                        checklist.SetBonus(int.Parse(parts[4]));
                        checklist.SetTimes(int.Parse(parts[5]));
                        checklist.SetCompleted(int.Parse(parts[6]));
                        goals.Add(checklist);
                    }
                    menu = 0;
                }
            }

            if (menu == 5)
            {
                int number = 1;

                Console.WriteLine("The goals are:");
                foreach (Goal goal in goals)
                {
                    Console.WriteLine($"{number}. {goal.GetName()}");

                    number = number + 1;
                }
                
                Console.Write("Which goal did you accomplish? ");
                menu = 0;
                menu = int.Parse(Console.ReadLine());
                menu = menu - 1;
                int i = 0;
                
                foreach (Goal goal in goals)
                {

                    if (menu == i)
                    {
                        points = points + goal.RecordEvent();
                        goal.IsComplete();
                    }
                    
                    i = i + 1;
                }
                menu = 0;
            }

            if (menu == 6)
            {
                Console.WriteLine("Do you really want to quit? (Y/N)");
                string confirm = Console.ReadLine();

                if (confirm == "Y" || confirm == "y")
                {
                    quit = true;
                }
            }
        }
    }
}