using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Board humanBoard = new Board();
        Board computerBoard = new Board();
        bool run = true;

        Computer computer = new Computer();
        Human human = new Human();

        Console.WriteLine("Welcome to Battleship!");

        humanBoard.PopulateDisplay(computer.CheckLocations());
        humanBoard.PopulateBoard(human.GetPlayerIndicators());
        human.RequestLocation(computer.GetStatuses());
        
        humanBoard.PopulateDisplay(computer.CheckLocations());
    }
}