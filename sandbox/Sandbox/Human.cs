using System.Diagnostics.CodeAnalysis;
using System.Text;

public class Human: Player
{

    public Human()
    {
        Console.WriteLine("What is your name? ");
        SetName(Console.ReadLine());
        SetPositions(PlaceShips());
    }

    public override String[,] PlaceShips()
    {
        int index = 1;
        int count = 0;
        string letters = "ABCDEFGHIJ";
        Fleet fleet = new Fleet();
        List<Ship> ships = new List<Ship>();
        Status[,] statuses = new Status[10, 10];
        ships = fleet.GetFleet();
        bool isHorizontal = true;
        String[,] positions = new String[10,10];

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
            Status status = ships[menu].GetStatus();
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
                        if (positions[i, j] != "O" && positions[i, j] != "X")
                        {
                            positions[i, j] = "~";
                            statuses[i, j] = Status.Empty;
                        }

                        if (positions[i, j] == "X")
                        {
                            positions[i, j] = "O";
                        }
                    }
                }

                if (isHorizontal == true)
                {
                    for (int i = moveY; i <= moveY + hitPoints; i++)
                    {
                        if (positions[moveX, i] == "O")
                        {
                            positions[moveX, i] = "X";
                            isOverlap = true;
                        }

                        else
                        {
                            positions[moveX, i] = "*";
                        }
                    }
                }

                else
                {
                    for (int i = moveX; i <= moveX + hitPoints; i++)
                    {
                        if (positions[i, moveY] == "O")
                        {
                            positions[i, moveY] = "X";
                            isOverlap = true;
                        }

                        else if (positions[i, moveY] != "X")
                        {
                            positions[i, moveY] = "*";
                        }
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{letters[i]}");
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write("[");
                        Console.Write(positions[i, j]);
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
                        if (positions[i, j] == "*")
                        {
                            positions[i, j] = "O";
                            statuses[i, j] = ships[menu].GetStatus();
                        }
                    }
                }

                count++;
                ships.RemoveAt(menu);
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Ships overlap, try again...\r\n");
            }
        }
        SetStatuses(statuses);
        return positions;
    }

    public override void RequestLocation(String[,] positions)
    {
        bool same = true;

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

            Peg peg = new Peg(xCoord, yCoord);
            if (positions[xCoord, yCoord] == "O")
            {
                peg.SetStatus(Status.Hit);
                positions[xCoord, yCoord] = "H";
                same = false;
                //_pegs.Add(peg);
            }

            else if (positions[xCoord, yCoord] == "~")
            {
                peg.SetStatus(Status.Miss);
                positions[xCoord, yCoord] = "M";
                same = false;
                //_pegs.Add(peg);
            }

            else if (peg.GetStatus() == Status.Hit || peg.GetStatus() == Status.Miss || peg.GetStatus() == Status.Sink)
            {
                same = true;
                Console.WriteLine("Location already chosen, please try again.");
            }
        }
    }
}