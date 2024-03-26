public class Human: Player
{
    private List<Peg> _pegs = new List<Peg>();
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
        ships = fleet.GetFleet();
        bool isHorizontal = true;
        String[,] positions = new String[10,10];

        while (count < 5)
        {
            ConsoleKey input = ConsoleKey.Insert;
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
                        if (positions[i, j] != "O" && positions[i, j] != "X")
                        {
                            positions[i, j] = "~";
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

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (positions[i, j] == "*")
                    {
                        positions[i, j] = "O";
                        count++;
                        ships.RemoveAt(menu);
                    }
                }
            }
        }
        return positions;
    }

    public override void RequestLocation()
    {
        bool same = true;
        while (same == true)
        {
            Peg peg = new Peg();
            if (peg.GetStatus() == "O")
            {
                peg.SetStatus("H");
                same = false;
                _pegs.Add(peg);
            }

            else if (peg.GetStatus() == "~")
            {
                peg.SetStatus("M");
                same = false;
                _pegs.Add(peg);
            }

            else if (peg.GetStatus() == "H" || peg.GetStatus() == "M" || peg.GetStatus() == "S")
            {
                same = true;
                Console.WriteLine("Location already chosen, please try again.");
            }
        }
    }
}