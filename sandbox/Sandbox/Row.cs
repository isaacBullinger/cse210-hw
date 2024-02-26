using System.Xml;

public class Row
{
    private List<string> _displayRow = new List<string>();
    private List<string> _boardRow = new List<string>();

    public void GetDisplayRow(string letter)
    {
        Peg peg = new Peg();
        _displayRow.Add(letter);
        Console.Write("| |");
        Console.Write($"{letter}");
        for (int i = 0; i < 10; i ++)
        {
            Console.Write("[");
            _displayRow.Add(peg.GetStatus());
            Console.Write(peg.GetStatus());
            Console.Write("]");
        }
        Console.Write("|\r\n");
    }

    public void GetBoardRow(string letter)
    {
        Peg peg = new Peg();

        _boardRow.Add(letter);
        Console.Write(@$"  \ \");
        Console.Write($"{letter}");
        for (int i = 0; i < 10; i ++)
        {
            Console.Write(@"\");
            _displayRow.Add(peg.GetStatus());
            Console.Write(peg.GetStatus());
            Console.Write(@"\");
        }
        Console.Write(@"\");
        Console.Write("\r\n");
    }
}