using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        bool run = true;

        Computer computer = new Computer();

        board.PopulateDisplay();
        board.PopulateBoard(computer.GetPostions());
    }
}