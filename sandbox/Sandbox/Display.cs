using System;

public class Display
{
    private String[,] _board = new String[10, 10];
    private String[,] _display = new String[10, 10];
    private string _letters = "ABCDEFGHIJ";
    
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
                _board[i, j] = "~";
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
                _display[i, j] = "~";
                Console.Write($"{_display[i, j]}");
                Console.Write("]");
            }

            Console.Write("|");
            Console.WriteLine();

        }

        Console.WriteLine(@" \|\``0``1``2``3``4``5``6``7``8``9`\");
    }
}