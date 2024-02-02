using System;
using System.ComponentModel.Design;
using System.Net.Quic;

// Creativity & Exceeding Core Requirements:
// In Journal class, if there are no entries a
// message shows that tells the user to load a file.

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

            else if (select == "2")
            {
                newEntry.DisplayJournal();
            }

            else if (select == "3")
            {
                newEntry.LoadJournal();
            }

            else if (select == "4")
            {
                newEntry.SaveJournal();
            }

            // Creativity & Exceeding Core Requirements:
            // Asks user for confirmation before closing.

            else if (select == "5")
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

                // Creativity & Exceeding Core Requirements:
                // Error message if user types anything other than a y or n.

                else if (confirm != "n" || confirm != "y")
                {
                    menu = true;
                    Console.WriteLine("Wrong input, please type y or n.");
                }
            }
            else
            {
                Console.WriteLine("Wrong input, please type 1, 2, 3, 4, or 5.");
            }
        }
    }
}