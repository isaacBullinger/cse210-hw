using System;
using System.ComponentModel.DataAnnotations;

public class Computer: Player
{
    private int _moveX;
    private int _moveY;
    public Computer()
    {
        SetName("Computer");
        SetPositions(PlaceShips());
    }

    public override String[,] PlaceShips()
    {
        int count = 0;
        string letters = "ABCDEFGHIJ";
        Fleet fleet = new Fleet();
        List<Ship> ships = fleet.GetFleet();
        Status[,] statuses = new Status[10, 10];
        bool display = false;
        bool isHorizontal;
        String[,] positions = new String[10,10];

        while (count < 5)
        {

            bool isOverlap = false;
            int hitPoints = ships[0].GetHP();
            hitPoints--;

            Random random = new Random();
            int randomOrientation = random.Next(0,2);

            if (randomOrientation == 1)
            {
                isHorizontal = false;
                _moveX = random.Next(9 - hitPoints);
                _moveY = random.Next(9);
            }

            else
            {
                isHorizontal = true;
                _moveX = random.Next(9);
                _moveY = random.Next(9 - hitPoints);
            }

            Console.Clear();

            if (display == true)
            {
                Console.WriteLine("  0  1  2  3  4  5  6  7  8  9");
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
                for (int i = _moveY; i <= _moveY + hitPoints; i++)
                {
                    if (positions[_moveX, i] == "O")
                    {
                        positions[_moveX, i] = "X";
                        isOverlap = true;
                    }

                    else
                    {
                        positions[_moveX, i] = "*";
                    }
                }
            }

            else
            {
                for (int i = _moveX; i <= _moveX + hitPoints; i++)
                {
                    if (positions[i, _moveY] == "O")
                    {
                        positions[i, _moveY] = "X";
                        isOverlap = true;
                    }

                    else if (positions[i, _moveY] != "X")
                    {
                        positions[i, _moveY] = "*";
                    }
                }
            }

            if (display == true)
            {
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
            }

            Console.WriteLine();

            if (isOverlap == false)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (positions[i, j] == "*")
                        {
                            positions[i, j] = "O";
                            statuses[i, j] = ships[0].GetStatus();
                        }
                    }
                }
                
                count++;
                ships.RemoveAt(0);
            }

            if (display == true)
            {
                Thread.Sleep(1000);
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
            Random random = new Random();
            int xCoord = random.Next();
            int yCoord = random.Next();

            Peg peg = new Peg(xCoord, yCoord);

            if (peg.GetStatus() == Status.Aircraft_Carrier || peg.GetStatus() == Status.Battleship || peg.GetStatus() == Status.Cruiser || peg.GetStatus() == Status.Destroyer || peg.GetStatus() == Status.Submarine)
            {
                peg.SetStatus(Status.Hit);
                same = false;
                //AddPeg(peg);
            }

            else if (peg.GetStatus() == Status.Empty)
            {
                peg.SetStatus(Status.Miss);
                same = false;
                //AddPeg(peg);
            }

            else if (peg.GetStatus() == Status.Hit || peg.GetStatus() == Status.Miss || peg.GetStatus() == Status.Sink)
            {
                same = true;
                Console.WriteLine("Location already chosen, please try again.");
            }
        }
    }
}