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

    public Scripture(Reference reference, string text, string text0)
    {
        string[] scriptureWords = text.Split(" ");
        foreach (string word in scriptureWords) 
        {
            _words.Add(new Word(word));
        }

        string[] scriptureWords2 = text0.Split(" ");
        foreach (string word in scriptureWords2)
        {
            _words.Add(new Word(word));
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

        for (int i = 0; i < 3; i++)
        {
            int random = randomGenerator.Next(0,_words.Count);
            _words[random].Hide();
        }
    }

    public bool CompleteHide()
    {
        bool allHidden =false;
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