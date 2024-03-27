using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        bool run = true;

        Computer computer = new Computer();
        //Human human = new Human();

        Console.WriteLine("Welcome to Battleship!");

        board.PopulateDisplay();
        board.PopulateBoard(computer.GetPostions());

        board.DisplayStatus(computer.GetStatuses());
    }
}