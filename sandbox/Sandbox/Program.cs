using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Board humanBoard = new Board();
        bool run = true;

        Computer computer = new Computer();
        Console.WriteLine("Welcome to Battleship!");
        Human human = new Human();

        while (run == true)
        {
            humanBoard.PopulateDisplay(human.GetOpponentIndicators());
            humanBoard.PopulateBoard(human.GetPlayerIndicators());
            human.RequestLocation(computer.GetPlayerStatuses());

            computer.RequestLocation(human.GetPlayerStatuses());
            human.CheckLocations(computer.GetOpponentStatuses());
        }
    }
}