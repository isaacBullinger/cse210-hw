using System;
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
            Console.WriteLine("Select a choice from the menu: ");
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
                    Console.WriteLine("What is the name of your goal? ");
                    simple.SetName(Console.ReadLine());
                    Console.WriteLine("What is the description? ");
                    simple.SetDescription(Console.ReadLine());
                    Console.WriteLine("What are the points you wish to assign to this goal?");
                    simple.SetPoints(Console.ReadLine());
                }

                if (menu == 2)
                {
                    Eternal eternal = new Eternal();
                    Goal goal = new Goal();
                    Console.WriteLine("What is the name of your goal? ");
                    goal.SetName(Console.ReadLine());
                    Console.WriteLine("What is the description? ");
                    goal.SetDescription(Console.ReadLine());
                    Console.WriteLine("What are the points you wish to assign to this goal?");
                    goal.SetPoints(Console.ReadLine());

                }

                if (menu == 3)
                {
                    Checklist checklist = new Checklist();
                }
            }

            if (menu == 2)
            {
                Console.WriteLine("The goals are:");
                string check = " ";
                //Goal goal = new Goal();
                //foreach (goal in goals)
                //{
                    // if (goal.IsComplete == true)
                    //{
                        //check = X;
                    //}
                    // else
                    //{
                        //check = " ";
                    //}
                    //Console.WriteLine($"{number}. [{check}] {name} ({description})")
                //}
            }

            if (menu == 3)
            {
                Filename();
            }

            if (menu == 4)
            {
                Filename();
            }

            if (menu == 5)
            {
                Console.WriteLine("Record Event!");
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