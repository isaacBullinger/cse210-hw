using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        bool run = true;

        while (run == true)
        {
            Console.WriteLine("Welcome to Battleship! To begin, select a ship to place:\r\n");
            Console.WriteLine("1. Cruiser           (2 slots)   Orientation:");
            Console.WriteLine("2. Destroyer         (3 slots)   Horizontal (H)");
            Console.WriteLine("3. Submarine         (3 slots)   Vertical   (V)");
            Console.WriteLine("4. Battleship        (4 slots)");
            Console.WriteLine("5. Aircraft Carrier  (5 slots)");

            board.PlaceShip(5, true);

            board.PlacePeg();
        
            board.PopulateDisplay();
            board.PopulateBoard();
        }
    }
}