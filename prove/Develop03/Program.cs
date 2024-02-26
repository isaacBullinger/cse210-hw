using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;

// I showed creativity and exceeded requirements by making sure that every time the <enter> key was pressed exactly 3 words are replaced. This is shown in the comment in the Scripture class.
class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        bool complete = false;
        int count = 0;
        List<string> verses = new List<string>();
        string confirm;
        string proverbs5 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        string proverbs6 = "In all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference = new Reference(5,6);
        verses.Add(proverbs5);
        verses.Add(proverbs6);
        Scripture scripture = new Scripture(reference,verses);

        while (quit == false && complete == false)
        {
            Console.Clear();
            Console.Write(reference.GetText());

            if (count == 0)
            {
                scripture.GetText();
            }

            else if (count > 0)
            {
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