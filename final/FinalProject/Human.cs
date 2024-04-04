using System.Diagnostics.CodeAnalysis;
using System.Text;

public class Human: Player
{

    public Human()
    {
        Console.WriteLine("What is your name? ");
        SetName(Console.ReadLine());
        Console.Clear();
        SetPlayerCells(PlaceShips());
    }

    public override Cell[,] PlaceShips()
    {
        int index = 1;
        int count = 0;
        string letters = "ABCDEFGHIJ";
        Fleet fleet = new Fleet();
        List<Ship> trackShips = fleet.GetFleet();
        List <Ship> humanShips = new List<Ship>();
        Cell[,] cells = new Cell[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                cells[i, j] = new Cell();
            }
        }
        bool isHorizontal = true;
        Char[,] indicators = new Char[10,10];

        Console.WriteLine("Begin by placing your ships:");

        while (count < 5)
        {
            ConsoleKey input = ConsoleKey.Insert;
            bool isOverlap = false;
            int moveX = 0;
            int moveY = 0;
            int menu;

            foreach (Ship ship in trackShips)
            {
                ship.DisplayShip(index);
                index++;
            }

            index = 1;

            Console.Write("\r\nPlease select a ship to place: ");
            while (!int.TryParse(Console.ReadLine(), out menu) || menu > trackShips.Count() || menu <= 0)
            {
                Console.Write("Invalid input. Please select a ship to place: ");
            }

            menu--;

            int hitPoints = trackShips[menu].GetHP();
            hitPoints--;

            while (!Console.KeyAvailable && input != ConsoleKey.Enter)
            {
                Console.Clear();

                Console.WriteLine(" Movement:   Rotate (R)");
                Console.WriteLine("     W");
                Console.WriteLine("   A S D\r\n");
                Console.WriteLine("Press <Enter> to place.\r\n");

                Console.WriteLine("  0  1  2  3  4  5  6  7  8  9");

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

                //Start here
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (indicators[i, j] != 'O' && indicators[i, j] != 'X')
                        {
                            cells[i, j].SetStatus(Status.Empty);
                            cells[i, j].SetIndicator(' ');
                            indicators[i, j] = ' ';
                        }

                        if (indicators[i, j] == 'X')
                        {
                            indicators[i, j] = 'O';
                        }
                    }
                }
                //End here

                if (isHorizontal == true)
                {
                    for (int i = moveY; i <= moveY + hitPoints; i++)
                    {
                        if (indicators[moveX, i] == 'O')
                        {
                            indicators[moveX, i] = 'X';
                            isOverlap = true;
                        }

                        else
                        {
                            indicators[moveX, i] = '*';
                            isOverlap = false;
                        }
                    }
                }

                else
                {
                    for (int i = moveX; i <= moveX + hitPoints; i++)
                    {
                        if (indicators[i, moveY] == 'O')
                        {
                            indicators[i, moveY] = 'X';
                            isOverlap = true;
                        }

                        else if (indicators[i, moveY] != 'X')
                        {
                            indicators[i, moveY] = '*';
                            isOverlap = false;
                        }
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (indicators[i, j] == 'X')
                        {
                            isOverlap = true;
                        }
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{letters[i]}");
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write("[");
                        Console.Write(indicators[i, j]);
                        Console.Write("]");
                    }
                    Console.WriteLine();
                }

                input = Console.ReadKey(true).Key;
                Console.WriteLine();
            }

            if (isOverlap == false)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (indicators[i, j] == '*')
                        {
                            cells[i, j].SetIndicator('O');
                            cells[i, j].SetStatus(trackShips[0].GetStatus());
                            indicators[i, j] = 'O';
                        }
                    }
                }
                count++;
                humanShips.Add(trackShips[menu]);
                trackShips.RemoveAt(menu);
                Console.Clear();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Ships overlap, try again...\r\n");
                Thread.Sleep(3000);
            }
        }
        SetFleet(humanShips);
        return cells;
    }

    public override void RequestLocation(Status[,] opponentStatuses)
    {
        bool same = true;
        Cell[,] opponentCells = GetOpponentCells();

        while (same == true)
        {
            int xCoord = 0;

            Console.Write("Choose a letter (A-J): ");
            string letter = Console.ReadLine().ToUpper();

            if (letter.Length != 1 || !char.IsLetter(letter[0]) || letter[0] < 'A' || letter[0] > 'J')
            {
                Console.WriteLine("Invalid input, please choose a letter (A-J)");
                continue;
            }

            xCoord = letter[0] - 'A';

            Console.Write("Choose a number (0-9): ");
            if (!int.TryParse(Console.ReadLine(), out int yCoord) || yCoord < 0 || yCoord > 9)
            {
                Console.WriteLine("Invalid input, please choose a number between (0-9)");
                continue;
            }

            if (opponentStatuses[xCoord, yCoord] == Status.Hit || opponentStatuses[xCoord, yCoord] == Status.Miss || opponentStatuses[xCoord, yCoord] == Status.Sink)
            {
                same = true;
                Console.WriteLine("Location already chosen, please try again.");
            }

            else if (opponentStatuses[xCoord, yCoord] == Status.Aircraft_Carrier || opponentStatuses[xCoord, yCoord] == Status.Battleship || opponentStatuses[xCoord, yCoord] == Status.Cruiser || opponentStatuses[xCoord, yCoord] == Status.Destroyer || opponentStatuses[xCoord, yCoord] == Status.Submarine)
            {
                opponentCells[xCoord, yCoord].SetStatus(Status.Hit);
                opponentCells[xCoord, yCoord].SetIndicator('H');
                Console.Clear();
                Console.WriteLine("Hit!");
                same = false;
            }

            else if (opponentStatuses[xCoord, yCoord] == Status.Empty)
            {
                opponentCells[xCoord, yCoord].SetStatus(Status.Miss);
                opponentCells[xCoord, yCoord].SetIndicator('M');
                Console.Clear();
                Console.WriteLine("Miss!");
                same = false;
            }
        }
        SetOpponentCells(opponentCells);
    }
}