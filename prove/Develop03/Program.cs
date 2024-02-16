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
        int firstVerse = 5;
        int secondVerse = 6;
        Reference reference = new Reference(firstVerse,secondVerse);
        Scripture scripture = new Scripture(firstVerse,secondVerse,proverbs5,proverbs6);
        
        Console.Write(reference.GetText());
        scripture.GetText();


//        Reference reference = new Reference(firstVerse);
//        List<string> texts = new List<string>();
//        Console.Write(reference.GetText());

//        string[] scriptureWords = proverbs5.Split(" ");
//        foreach (string word in scriptureWords) 
//        {
//            words.Add(new Word(word));
//            Console.Write($" {word}");
//        }
//        if (secondVerse > 0)
//        {
//            scriptureWords2 = proverbs6.Split(" ");
//            foreach (string word in scriptureWords2)
//            {
//                words.Add(new Word(word));
//                Console.Write($" {word}");
//            }
//        }


//        while (quit == false)
//            {
//                Scripture scripture = new Scripture();
//                Console.WriteLine($"{scripture.GetText()}\r\n");
//                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
//                confirm = Console.ReadLine();
//
//                if (confirm == "quit")
//                    {
//                        quit = true;
//                    }
//                Console.Clear();
//            }
    }
}