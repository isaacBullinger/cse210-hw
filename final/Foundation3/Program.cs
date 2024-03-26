using System;
using System.Collections.Generic;

class Ship
{
    public int Size { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsHorizontal { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        const int numberOfShips = 5;
        const int gridSize = 10;
        string[,] os = new string[gridSize, gridSize];
        List<Ship> ships = new List<Ship>();

        for (int shipIndex = 0; shipIndex < numberOfShips; shipIndex++)
        {
            Ship ship = new Ship();
            ship.Size = 0;
            ship.X = 0;
            ship.Y = 0;
            ship.IsHorizontal = true;

            Console.WriteLine($"How many slots does ship {shipIndex + 1} take? ");
            ship.Size = int.Parse(Console.ReadLine());
            ship.Size--;

            while (true)
            {
                Console.Clear();

                // Update ship position based on input
                ConsoleKey input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.W && ship.X > 0)
                {
                    ship.X--;
                }
                else if (input == ConsoleKey.A && ship.Y > 0)
                {
                    ship.Y--;
                }
                else if (input == ConsoleKey.S)
                {
                    if (ship.IsHorizontal && ship.X < gridSize - 1)
                    {
                        ship.X++;
                    }
                    else if (!ship.IsHorizontal && ship.X < gridSize - ship.Size - 1)
                    {
                        ship.X++;
                    }
                }
                else if (input == ConsoleKey.D)
                {
                    if (ship.IsHorizontal && ship.Y < gridSize - ship.Size - 1)
                    {
                        ship.Y++;
                    }
                    else if (!ship.IsHorizontal && ship.Y < gridSize - 1)
                    {
                        ship.Y++;
                    }
                }
                else if (input == ConsoleKey.H && ship.Y <= gridSize - ship.Size - 1)
                {
                    ship.IsHorizontal = true;
                }
                else if (input == ConsoleKey.V && ship.X <= gridSize - ship.Size - 1)
                {
                    ship.IsHorizontal = false;
                }

                // Check if the ship placement is valid and move to the next ship if it is
                if (IsValidPlacement(ships, ship))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid ship placement. Please try again.");
                }
            }

            ships.Add(ship);
        }

        // Display the final grid with all ships placed
        Console.Clear();
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                os[i, j] = "~";
            }
        }

        foreach (var ship in ships)
        {
            if (ship.IsHorizontal)
            {
                for (int i = ship.Y; i <= ship.Y + ship.Size; i++)
                {
                    os[ship.X, i] = "O";
                }
            }
            else
            {
                for (int i = ship.X; i <= ship.X + ship.Size; i++)
                {
                    os[i, ship.Y] = "O";
                }
            }
        }

        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                Console.Write(os[i, j]);
            }
            Console.WriteLine();
        }
    }

    static bool IsValidPlacement(List<Ship> ships, Ship currentShip)
    {
        foreach (var ship in ships)
        {
            if (currentShip.IsHorizontal)
            {
                if (currentShip.X == ship.X && currentShip.Y >= ship.Y && currentShip.Y <= ship.Y + ship.Size)
                {
                    return false;
                }
                for (int i = currentShip.Y; i <= currentShip.Y + currentShip.Size; i++)
                {
                    if (ship.X >= currentShip.X - 1 && ship.X <= currentShip.X + 1 && i >= ship.Y - 1 && i <= ship.Y + ship.Size + 1)
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (currentShip.Y == ship.Y && currentShip.X >= ship.X && currentShip.X <= ship.X + ship.Size)
                {
                    return false;
                }
                for (int i = currentShip.X; i <= currentShip.X + currentShip.Size; i++)
                {
                    if (ship.Y >= currentShip.Y - 1 && ship.Y <= currentShip.Y + 1 && i >= ship.X - 1 && i <= ship.X + ship.Size + 1)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}
