using System;
using System.ComponentModel.Design;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        string select = "0";
        bool menu = true;
        Journal newEntry = new Journal();

        while (menu == true)
        {

            // Displays menu.

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            select = Console.ReadLine();

            if (select == "1")
            {
                newEntry.WriteEntry();
            }

            if (select == "2")
            {
                newEntry.DisplayJournal();
            }

            if (select == "3")
            {
                newEntry.LoadJournal();
            }

            if (select == "4")
            {
                newEntry.SaveJournal();
            }

            // Asks user for confirmation before closing.

            if (select == "5")
            {
                Console.WriteLine("Do you really want to quit? (Type y/n)");
                string confirm = Console.ReadLine();

                if (confirm == "n" || confirm == "y")
                {
                    if (confirm == "n")
                    {
                        menu = true;
                    }                
                
                    else if (confirm == "y")
                    {
                        menu = false;
                    }
                }

                else if (confirm != "n" || confirm != "y")
                {
                    menu = true;
                    Console.WriteLine("Wrong input, try again...");
                }
            }
        }
    }
}