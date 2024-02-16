using System;

class Program
{
    static void Main(string[] args)
    {
        string word = "Hello";

        word = "";
        foreach (char letter in word)
        {
            word += "_";
        }
        Console.Write(word);
    }
}