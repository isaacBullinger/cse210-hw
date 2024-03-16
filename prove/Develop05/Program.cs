using System;

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
            Console.Clear();
            Console.WriteLine($"\r\nYou have {points} points.\r\n");

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
                Console.WriteLine("\r\nThe types of Goals are:");
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

                    if(goal.GetTypeGoal() == "ChecklistGoal:")
                    {
                        List<string> split = new List<string>();
                        split = goal.RecordGoal();
                        Console.WriteLine($"  {number}. [{check}] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {split[5]}/{split[6]}");
                    }

                    else
                    {
                        Console.WriteLine($"  {number}. [{check}] {goal.GetName()} ({goal.GetDescription()})");
                    }

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
                        List<string> words = new List<string>();
                        words = goal.RecordGoal();
                        foreach (string word in words)
                        {
                            outputFile.Write(word);
                            outputFile.Write("~");
                        }

                        outputFile.WriteLine();

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
                        Simple simple = new Simple(parts[1], parts[2], parts[3], parts[4]);
                        goals.Add(simple);
                    }

                    if (parts[0] == "EternalGoal:")
                    {
                        Eternal eternal = new Eternal(parts[1], parts[2], parts[3]);
                        goals.Add(eternal);
                    }

                    if (parts[0] == "ChecklistGoal:")
                    {
                        Checklist checklist = new Checklist(parts[1], parts[2], parts[3], int.Parse(parts[6]), int.Parse(parts[4]), int.Parse(parts[5]));
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
                
                menu = int.Parse(Console.ReadLine());
                menu = menu - 1;
                int i = 0;
                int tempPoints;
                
                foreach (Goal goal in goals)
                {
                    if (menu == i)
                    {
                        tempPoints = goal.RecordEvent();
                        points = points + tempPoints;
                        goal.IsComplete();

                        Console.Clear();
                        Console.WriteLine($"Congratulations! You have earned {tempPoints} points!");

                        if (goal.GetTypeGoal() == "ChecklistGoal:")
                        {
                            if (goal.IsComplete() == true)
                            {
                                Console.WriteLine("Here is a firework show: ");
                                Thread.Sleep(3000);

                                Console.Clear();
                                Console.WriteLine(@"     ");
                                Console.WriteLine(@"     ");
                                Console.WriteLine(@"  ^  ");
                                Thread.Sleep(500);
                                Console.Clear();

                                Console.WriteLine(@"     ");
                                Console.WriteLine(@"  ^  ");
                                Console.WriteLine(@"     ");
                                Thread.Sleep(500);
                                Console.Clear();

                                Console.WriteLine(@"     ");
                                Console.WriteLine(@"  *  ");
                                Console.WriteLine(@"     ");
                                Thread.Sleep(500);
                                Console.Clear();

                                Console.WriteLine(@"\ | /");
                                Console.WriteLine(@"--*--");
                                Console.WriteLine(@"/ | \");
                                Thread.Sleep(500);
                                Console.Clear();

                                Console.WriteLine(@"` ' `");
                                Console.WriteLine(@":- _;");
                                Console.WriteLine(@".` ',");
                                Thread.Sleep(500);
                                Console.Clear();

                                Console.WriteLine(@"` ' `");
                                Console.WriteLine(@"     ");
                                Console.WriteLine(@".   ,");
                                Thread.Sleep(500);
                                Console.Clear();
                            }
                        }
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