using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Board humanBoard = new Board();
        Board computerBoard = new Board();
        bool end = false;
        string winner;

        Computer computer = new Computer();
        Console.WriteLine("Welcome to Battleship!");
        Human human = new Human();

        while (end == false)
        {
            Console.WriteLine("Human");
            humanBoard.PopulateDisplay(human.GetOpponentIndicators());
            humanBoard.PopulateBoard(human.GetPlayerIndicators());
            human.RequestLocation(computer.GetPlayerStatuses());
            computer.CheckLocations(human.GetOpponentStatuses());
            human.CheckShips(computer.GetPlayerStatuses());

            Console.WriteLine("Computer");
            computerBoard.PopulateDisplay(computer.GetOpponentIndicators());
            computerBoard.PopulateBoard(computer.GetPlayerIndicators());
            computer.RequestLocation(human.GetPlayerStatuses());
            human.CheckLocations(computer.GetOpponentStatuses());
            computer.CheckShips(human.GetPlayerStatuses());

            end = computer.CheckWin();
            end = human.CheckWin();
        }
        Console.WriteLine("Game over");


    }
}