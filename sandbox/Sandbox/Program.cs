using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Display display = new Display();

        display.PopulateDisplay();
        display.PopulateBoard();
    }
}