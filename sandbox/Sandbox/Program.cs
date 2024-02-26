using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Display display = new Display();
        Board board = new Board();

        Console.Clear();
        Console.WriteLine(" ________________________________");
        Console.WriteLine($@"|\_______________________________\");
        Console.WriteLine("| |  0  1  2  3  4  5  6  7  8  9 |");
        display.UserDisplay();
        Console.WriteLine(@" \|\``0``1``2``3``4``5``6``7``8``9`\");
        board.BoardDisplay();
        Console.WriteLine(@"            \ \_______________________________\");
        Console.WriteLine(@"             \|___________BATTLESHIP___________|");
    }
}