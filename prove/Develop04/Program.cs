using System;

class Program
{
    static void Main(string[] args)
    {
        string word = "Hello";

        foreach (int letter in word)
        {
            Console.Write("_");
        }
    }
}