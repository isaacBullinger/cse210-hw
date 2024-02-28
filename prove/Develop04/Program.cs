using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int time = 10;
        bool menu = true;
        string select = "0";

        while (menu == true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            select = Console.ReadLine();
            
            if (select == "1")
            {
                Breathing breathing = new Breathing();
                breathing.RunBreathing();
            }

            else if (select == "2")
            {
                Reflecting reflecting = new Reflecting();
                reflecting.RunReflecting();
            }

            else if (select == "3")
            {
                Listing listing = new Listing();
                listing.RunListing();
            }
            
            else if (select == "4")
            {
                menu = false;
            }
        }
    }
}