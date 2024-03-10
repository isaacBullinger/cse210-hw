using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();

        board.PlacePeg(5, 5);
        
        board.PopulateDisplay();
        board.PopulateBoard();
    }
}