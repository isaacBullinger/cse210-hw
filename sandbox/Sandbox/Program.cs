using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        bool run = true;

        //Computer computer = new Computer();
        Human human = new Human();

        board.PopulateDisplay();
        board.PopulateBoard(human.GetPostions());
    }
}