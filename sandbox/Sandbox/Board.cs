public class Board
{
    // Board handles display.
    private Char[,] _board = new Char[10, 10];
    private Char[,] _display = new Char[10, 10];
    private string _letters = "ABCDEFGHIJ";

    public void PopulateBoard(Char[,] characters)
    {
        _board = characters;
        string space = " ";
        for (int i = 0; i < _board.GetLength(0); i++)
        {
            Console.Write(space);
            space += space;
            Console.Write(@$" \ \{_letters[i]}");
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                if (_board[i, j] != '*' && _board[i, j] != 'O' && _board[i, j] != '~')
                {
                    _board[i, j] = ' ';
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

    public void PopulateDisplay(Char[,] opponent)
    {
        _display = opponent;
        Console.WriteLine(" ________________________________");
        Console.WriteLine($@"|\_______________________________\");
        Console.WriteLine("| |  0  1  2  3  4  5  6  7  8  9 |");

        for (int i = 0; i < _display.GetLength(0); i++)
        {
            Console.Write($"| |{_letters[i]}");
            for (int j = 0; j < _display.GetLength(1); j++)
            {
                Console.Write("[");
                if (_display[i, j] != '*' && _display[i, j] != 'O' && _display[i, j] != '~')
                {
                    _display[i, j] = ' ';
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