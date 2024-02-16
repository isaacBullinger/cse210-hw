using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        bool complete = false;
        int count = 0;
        string confirm;
        string proverbs5 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        string proverbs6 = "In all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference = new Reference(5,6);
        Scripture scripture = new Scripture(5,6,proverbs5,proverbs6);
        
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