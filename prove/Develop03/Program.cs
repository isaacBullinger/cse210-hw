using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        // list for scriptures
        bool quit = false;
        bool complete = false;
        int count = 0;
        string confirm;
        List<string> scriptures = new List<string>();
        string proverbs5 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        string proverbs6 = "In all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference = new Reference(5,6);
        Scripture scripture = new Scripture(reference,proverbs5,proverbs6);
        
        scriptures.Add(proverbs5);
        scriptures.Add(proverbs6);

        while (quit == false && complete == false)
        {
            Console.Clear();

            if (count == 0)
            {
                Console.Write(reference.GetText());
                scripture.GetText();
            }

            if (count > 0)
            {
                Console.Write(reference.GetText());
                scripture.HideWords();
                scripture.GetText();
            }

            count = count + 1;
            Console.WriteLine("\r\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            confirm = Console.ReadLine();


            if (confirm == "quit")
                {
                    quit = true;
                }

            complete = scripture.CompleteHide();

        }

    }
}