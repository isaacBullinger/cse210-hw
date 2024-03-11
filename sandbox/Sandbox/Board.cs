using System;
using System.Collections;
using System.Dynamic;
using System.Globalization;
using System.IO.Compression;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

public class Board
{
    private String[,] _board = new String[10, 10];
    private String[,] _display = new String[10, 10];
    private string _letters = "ABCDEFGHIJ";
    
    public void PlacePeg()
    {
        Peg peg = new Peg();
        int x = peg.SetXPosition();
        int y = peg.SetYPosition();
        _board[x, y] = "O";
    }

    public void PlaceShip(int hp, bool isHorizontal)
    {
        Ship ship = new Ship(hp, isHorizontal);
        bool place = false;

        string space = " ";
        for (int i = 0; i < _board.GetLength(0); i++)
        {
            Console.Write(space);
            space = space + " ";
            Console.Write(@$" \ \{_letters[i]}");
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                Console.Write(@"\");
                while (place == true)
                {
                    string move = Console.ReadLine();

                    if (move == "w")
                    {

                    }
                    if (move == "a")
                    {

                    }
                    if (move == "s")
                    {

                    }
                    if (move == "d")
                    
                    if (move == "P" || move == "p")
                    {
                        place = false;
                    }
                }
                Console.Write($"{_board[i, j]}");
                Console.Write(@"\");
            }
            Console.Write(@"\");
            Console.WriteLine();
        }
        Console.WriteLine(@"            \ \_______________________________\");
        Console.WriteLine(@"             \|___________BATTLESHIP___________|");
    }

    public void PopulateBoard()
    {
        string space = " ";
        for (int i = 0; i < _board.GetLength(0); i++)
        {
            Console.Write(space);
            space = space + " ";
            Console.Write(@$" \ \{_letters[i]}");
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                Console.Write(@"\");
                if (_board[i, j] != "H" && _board[i, j] != "O" && _board[i, j] != "M")
                {
                    _board[i, j] = "~";
                }
                Console.Write($"{_board[i, j]}");
                Console.Write(@"\");
            }
            Console.Write(@"\");
            Console.WriteLine();
        }
        Console.WriteLine(@"            \ \_______________________________\");
        Console.WriteLine(@"             \|___________BATTLESHIP___________|");
    }

    public void PopulateDisplay()
    {
        Console.WriteLine(" ________________________________");
        Console.WriteLine($@"|\_______________________________\");
        Console.WriteLine("| |  0  1  2  3  4  5  6  7  8  9 |");

        for (int i = 0; i < _display.GetLength(0); i++)
        {
            Console.Write($"| |{_letters[i]}");
            for (int j = 0; j < _display.GetLength(1); j++)
            {
                Console.Write("[");
                if (_display[i, j] != "H" ||_display[i, j] != "O" || _display[i, j] != "M")
                {
                    _display[i, j] = "~";
                }
                Console.Write($"{_display[i, j]}");
                Console.Write("]");
            }

            Console.Write("|");
            Console.WriteLine();
        }
        Console.WriteLine(@" \|\``0``1``2``3``4``5``6``7``8``9`\");
    }
}