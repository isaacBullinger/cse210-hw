using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Board humanBoard = new Board();
        Board computerBoard = new Board();
        string winner = null;

        Computer computer = new Computer();
        Console.WriteLine("Welcome to Battleship!");
        Human human = new Human();

        while (winner == null)
        {
            humanBoard.PopulateDisplay(human.GetOpponentIndicators());
            humanBoard.PopulateBoard(human.GetPlayerIndicators());
            human.RequestLocation(computer.GetPlayerStatuses());
            computer.CheckLocations(human.GetOpponentStatuses());
            human.CheckShips(computer.GetPlayerStatuses(), computer.GetName());

            if (human.CheckWin())
            {
                winner = computer.GetName();
            }

            computer.RequestLocation(human.GetPlayerStatuses());
            human.CheckLocations(computer.GetOpponentStatuses());
            computer.CheckShips(human.GetPlayerStatuses(), human.GetName());

            if (computer.CheckWin())
            {
                winner = human.GetName();
            }
        }
        Console.WriteLine($"{winner} wins!");
    }
}