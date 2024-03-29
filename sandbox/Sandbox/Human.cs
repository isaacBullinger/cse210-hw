using System.Diagnostics.CodeAnalysis;
using System.Text;

public class Human: Player
{

    public Human()
    {
        Console.WriteLine("What is your name? ");
        SetName(Console.ReadLine());
        SetPlayerPegs(PlaceShips());
    }

    public override Peg[,] PlaceShips()
    {
        int index = 1;
        int count = 0;
        string letters = "ABCDEFGHIJ";
        Fleet fleet = new Fleet();
        List<Ship> ships = fleet.GetFleet();
        Peg[,] pegs = new Peg[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                pegs[i, j] = new Peg();
            }
        }
        bool isHorizontal = true;
        Char[,] indicators = new Char[10,10];

        while (count < 5)
        {
            ConsoleKey input = ConsoleKey.Insert;
            bool isOverlap = false;
            int moveX = 0;
            int moveY = 0;
            int menu;

            foreach (Ship ship in ships)
            {
                ship.DisplayShip(index);
                index++;
            }

            index = 1;

            Console.WriteLine("\r\n Rotate (R)");
            Console.WriteLine(" Movement:");
            Console.WriteLine("     W");
            Console.WriteLine("   A S D");
            Console.WriteLine("Please select a ship to place, press <Enter> to place: ");
            menu = int.Parse(Console.ReadLine());

            if (menu > ships.Count() || menu < 0)
            {
                while (menu > ships.Count() || menu < 0)
                {
                    Console.WriteLine("Please select a ship to place, press <Enter> to place: ");
                    menu = int.Parse(Console.ReadLine());
                }
            }
            
            menu--;

            int hitPoints = ships[menu].GetHP();
            hitPoints--;

            while (!Console.KeyAvailable && input != ConsoleKey.Enter)
            {
                Console.Clear();

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

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (indicators[i, j] != 'O' && indicators[i, j] != 'X')
                        {
                            pegs[i, j].SetStatus(Status.Empty);
                            pegs[i, j].SetIndicator('~');
                            indicators[i, j] = '~';
                        }

                        if (indicators[i, j] == 'X')
                        {
                            indicators[i, j] = 'O';
                        }
                    }
                }

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
                            pegs[i, j].SetIndicator('O');
                            pegs[i, j].SetStatus(ships[0].GetStatus());
                            indicators[i, j] = 'O';
                        }
                    }
                }
                count++;
                ships.RemoveAt(menu);
                Console.Clear();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Ships overlap, try again...\r\n");
            }
        }
        return pegs;
    }

    public override void RequestLocation(Status[,] statuses)
    {
        bool same = true;
        Peg[,] pegs = GetOpponentPegs();

        while (same == true)
        {
            int xCoord = 0;

            Console.Write("Choose a letter (A-J): ");
            string letter = Console.ReadLine();

            if (letter == "A" || letter == "a")
            {
                xCoord = 0;
            }
            else if (letter == "B" || letter == "b")
            {
                xCoord = 1;
            }
            else if (letter == "C" || letter == "c")
            {
                xCoord = 2;
            }
            else if (letter == "D" || letter == "d")
            {
                xCoord = 3;
            }
            else if (letter == "E" || letter == "e")
            {
                xCoord = 4;
            }
            else if (letter == "F" || letter == "f")
            {
                xCoord = 5;
            }
            else if (letter == "G" || letter == "g")
            {
                xCoord = 6;
            }
            else if (letter == "H" || letter == "h")
            {
                xCoord = 7;
            }
            else if (letter == "I" || letter == "i")
            {
                xCoord = 8;
            }
            else if (letter == "J" || letter == "j")
            {
                xCoord = 9;
            }

            Console.Write("Choose a number (0-9): ");
            int yCoord = int.Parse(Console.ReadLine());

            if (statuses[xCoord, yCoord] == Status.Aircraft_Carrier || statuses[xCoord, yCoord] == Status.Battleship || statuses[xCoord, yCoord] == Status.Cruiser || statuses[xCoord, yCoord] == Status.Destroyer || statuses[xCoord, yCoord] == Status.Submarine)
            {
                pegs[xCoord, yCoord].SetStatus(Status.Hit);
                same = false;
            }

            else if (statuses[xCoord, yCoord] == Status.Empty)
            {
                pegs[xCoord, yCoord].SetStatus(Status.Miss);
                same = false;
            }

            else if (statuses[xCoord, yCoord] == Status.Hit || statuses[xCoord, yCoord] == Status.Miss || statuses[xCoord, yCoord] == Status.Sink)
            {
                same = true;
                Console.WriteLine("Location already chosen, please try again.");
            }
        }
        SetOpponentPegs(pegs);
    }
}