using System;
using System.ComponentModel.DataAnnotations;

public class Computer: Player
{
    private int _moveX;
    private int _moveY;
    public Computer()
    {
        SetName("Computer");
        SetPlayerCells(PlaceShips());
    }

    public override Cell[,] PlaceShips()
    {
        int count = 0;
        string letters = "ABCDEFGHIJ";
        Fleet fleet = new Fleet();
        List<Ship> ships = fleet.GetFleet();
        Cell[,] cells = new Cell[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                cells[i, j] = new Cell();
            }
        }
        //Testing purposes.
        bool display = false;
        bool isHorizontal;
        //For displaying the placement:
        Char[,] indicators = new Char[10,10];
        Random random = new Random();

        while (count < 5)
        {
            bool isOverlap = false;
            int hitPoints = ships[0].GetHP();
            hitPoints--;

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
                for (int i = _moveY; i <= _moveY + hitPoints; i++)
                {
                    if (indicators[_moveX, i] == 'O')
                    {
                        indicators[_moveX, i] = 'X';
                        isOverlap = true;
                    }

                    else
                    {
                        indicators[_moveX, i] = '*';
                    }
                }
            }

            else
            {
                for (int i = _moveX; i <= _moveX + hitPoints; i++)
                {
                    if (indicators[i, _moveY] == 'O')
                    {
                        indicators[i, _moveY] = 'X';
                        isOverlap = true;
                    }

                    else if (indicators[i, _moveY] != 'X')
                    {
                        indicators[i, _moveY] = '*';
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
                        Console.Write(indicators[i, j]);
                        Console.Write("]");
                    }
                    Console.WriteLine();
                }
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
                            cells[i, j].SetStatus(ships[0].GetStatus());
                            indicators[i, j] = 'O';
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
        return cells;
    }

    public override void RequestLocation(Status[,] opponentStatuses)
    {
        bool same = true;
        Cell[,] opponentCells = GetOpponentCells();
        Random random = new Random();

        while (same == true)
        {
            int xCoord = random.Next(9);
            int yCoord = random.Next(9);

            if (opponentStatuses[xCoord, yCoord] == Status.Aircraft_Carrier || opponentStatuses[xCoord, yCoord] == Status.Battleship || opponentStatuses[xCoord, yCoord] == Status.Cruiser || opponentStatuses[xCoord, yCoord] == Status.Destroyer || opponentStatuses[xCoord, yCoord] == Status.Submarine)
            {
                opponentCells[xCoord, yCoord].SetStatus(Status.Hit);
                opponentCells[xCoord, yCoord].SetIndicator('H');
                same = false;
            }

            else if (opponentStatuses[xCoord, yCoord] == Status.Empty)
            {
                opponentCells[xCoord, yCoord].SetStatus(Status.Miss);
                opponentCells[xCoord, yCoord].SetIndicator('M');
                same = false;
            }

            else if (opponentStatuses[xCoord, yCoord] == Status.Hit || opponentStatuses[xCoord, yCoord] == Status.Miss || opponentStatuses[xCoord, yCoord] == Status.Sink)
            {
                same = true;
            }
        }
        SetOpponentCells(opponentCells);
    }
}