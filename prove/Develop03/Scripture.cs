using System;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text.Encodings.Web;

class Scripture
{
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        string[] scriptureWords = text.Split(" ");

        foreach (string word in scriptureWords) 
        {
            _words.Add(new Word(word));
        }
    }

    public Scripture(Reference reference, List<string> scriptures)
    {
        
        foreach (string verse in scriptures)
        {
            string[] scriptureWords = verse.Split(" ");
            foreach (string word in scriptureWords)
            {
                _words.Add(new Word(word));
            }
        }
    }
    
    public void GetText()
    {
        foreach (Word word in _words)
        {
            Console.Write($" {word.Show()}");
        }
    }

    public void HideWords()
    {
        Random randomGenerator = new Random();
//        bool allHidden = false;

//        for (int i = 0; i < 3; i++)
//        {
//            int random = randomGenerator.Next(0,_words.Count);

            
            // Shows Creativity and Exceeds Core Requirements: This makes sure that there are always 3 words hidden when <enter> is pressed.
//            while (_words[random].IsHidden() == true)
//            {
//                random = randomGenerator.Next(0,_words.Count);
//
//                // This makes sure that the while loop breaks!
//                foreach (Word word in _words)
//                {
//                    if (word.IsHidden() == true)
//                    {
//                        allHidden = true;
//                    }
//
//                    else
//                    {
//                        allHidden = false;
//                        break;
//                    }
//                }
//
//                if (allHidden == true)
//                {
//                    break;
//                }
//            }
//            _words[random].Hide();
//        }
//    }

        int random = randomGenerator.Next(0, _words.Count);

        for (int i = 0; i < 3 && !CompleteHide(); ++i)
        {
            while(_words[random].IsHidden() == true)
            {
                random = randomGenerator.Next(0, _words.Count);
            }
            _words[random].Hide();
        }
    }

    public bool CompleteHide()
    {
        bool allHidden = false;

        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                allHidden = true;
            }
            else
            {
                allHidden = false;
                break;
            }
        }
        return allHidden;
    }
}