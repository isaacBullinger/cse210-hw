using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference();
        reference1._book = "Alma";
        reference1._chapter = 32;
        reference1.verse = 1;

        reference1.DisplayReference();
    }
}