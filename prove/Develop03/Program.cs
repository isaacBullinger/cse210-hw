using System;
using System.IO;

namespace SimpleJournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("Welcome to Simple Journal Program!");
                Console.WriteLine("1. Create a new journal entry");
                Console.WriteLine("2. View existing journal entries");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateJournalEntry();
                        break;
                    case "2":
                        ViewJournalEntries();
                        break;
                    case "3":
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CreateJournalEntry()
        {
            Console.WriteLine("\nCreating a new journal entry...");
            Console.Write("Enter your journal entry: ");
            string entry = Console.ReadLine();

            try
            {
                using (StreamWriter sw = File.AppendText("journal.txt"))
                {
                    sw.WriteLine($"[{DateTime.Now}] {entry}");
                    Console.WriteLine("Journal entry saved successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void ViewJournalEntries()
        {
            Console.WriteLine("\nViewing existing journal entries...\n");

            try
            {
                using (StreamReader sr = new StreamReader("journal.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No journal entries found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}