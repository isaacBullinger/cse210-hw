using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        int aircraftCarrier = 5;
        int battleship = 4;
        int submarine = 3;
        int destroyer = 3;
        int cruiser = 2;

        bool isHorizontal = true;
        ConsoleKey input = ConsoleKey.Insert;
        int hitPoints = 0;
        String[,] os = new String[10,10];
        int menu = 0;
        List<int> ships = new List<int>();

        ships.Add(cruiser);
        ships.Add(destroyer);
        ships.Add(submarine);
        ships.Add(battleship);
        ships.Add(aircraftCarrier);

        while (ships.Count() > 0)
        {
            input = ConsoleKey.Insert;
            int moveX = 0;
            int moveY = 0;

            Console.WriteLine("Welcome to Battleship! To begin, select a ship to place:\r\n");
            Console.WriteLine("1. Cruiser           (2 slots)   Orientation:");
            Console.WriteLine("2. Destroyer         (3 slots)   Horizontal (H)");
            Console.WriteLine("3. Submarine         (3 slots)   Vertical   (V)");
            Console.WriteLine("4. Battleship        (4 slots)");
            Console.WriteLine("5. Aircraft Carrier  (5 slots)");

            Console.WriteLine("Select a ship to place: ");
            menu = int.Parse(Console.ReadLine());
            menu--;
            
            hitPoints = ships[menu];
            for (int i = 0; i <= ships.Count(); i++)
            {
                if (i == menu)
                {
                    ships.Remove(menu);
                }
            }

            hitPoints--;

            while (!Console.KeyAvailable && input != ConsoleKey.Enter)
            {
                Console.Clear();

                if (input == ConsoleKey.W && moveX > 0)
                {
                    moveX--;
                }

                if (input == ConsoleKey.A && moveY > 0)
                {
                    moveY--;
                }

                if (input == ConsoleKey.S)
                {
                    if (isHorizontal == true && moveX < 9)
                    {
                        moveX++;
                    }

                    else if (isHorizontal == false && moveX < 9 - hitPoints)
                    {
                        moveX++;
                    }
                }

                if (input == ConsoleKey.D)
                {
                    if (isHorizontal == true && moveY < 9 - hitPoints)
                    {
                        moveY++;
                    }

                    else if (isHorizontal == false && moveY < 9)
                    {
                        moveY++;
                    }
                }

                if (input == ConsoleKey.R)
                {
                    if (isHorizontal == true && moveX <= 9 - hitPoints)
                    {
                        isHorizontal = false;
                    }

                    else if (isHorizontal == false && moveY <= 9 - hitPoints)
                    {
                        isHorizontal = true;
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (os[i, j] != "O")
                        {
                            os[i, j] = "~";
                        }
                    }
                }

                if (isHorizontal == true)
                {
                    for (int i = moveY; i <= moveY + hitPoints; i++)
                    {
                        os[moveX, i] = "*";
                    }
                }

                else
                {
                    for (int i = moveX; i <= moveX + hitPoints; i++)
                    {
                        os[i, moveY] = "*";
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(os[i, j]);
                    }
                    Console.WriteLine();
                }

                input = Console.ReadKey(true).Key;
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (os[i, j] == "*")
                    {
                        os[i, j] = "O";
                    }
                }
            }
        }
    }
}