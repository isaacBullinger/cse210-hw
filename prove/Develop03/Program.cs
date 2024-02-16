using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        string confirm;
        string proverbs5 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        string proverbs6 = "In all thy ways acknowledge him, and he shall direct thy paths.";
        List<Word> words = new List<Word>();
        Reference reference = new Reference(5,6);
        Scripture scripture = new Scripture(5,6,proverbs5,proverbs6);
        
        while (quit == false)
        {
            Console.Write(reference.GetText());
            scripture.GetText();
            confirm = Console.ReadLine();

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            confirm = Console.ReadLine();
            scripture.HideWords();

            if (confirm == "quit")
                {
                    quit = true;
                }
            Console.Clear();
        }

    }
}