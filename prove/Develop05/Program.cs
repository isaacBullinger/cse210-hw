using System;
using System.Globalization;
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
                string check = " ";

                Console.WriteLine("The goals are:");
                foreach (Goal goal in goals)
                {
                    Console.WriteLine($"{number}. [{check}] {goal.GetName()} {goal.GetDescription()}");

                    number = number + 1;
                }
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
                foreach (Goal goal in goals)
                {

                }
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