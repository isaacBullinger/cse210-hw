using System;

public class Board
{
    private Row _aRow = new Row();
    private Row _bRow = new Row();
    private Row _cRow = new Row();
    private Row _dRow = new Row();
    private Row _eRow = new Row();
    private Row _fRow = new Row();
    private Row _gRow = new Row();
    private Row _hRow = new Row();
    private Row _iRow = new Row();
    private Row _jRow = new Row();
    private List<Row> _rows = new List<Row>();

    public Board()
    {
        _rows.Add(_aRow);
        _rows.Add(_bRow);
        _rows.Add(_cRow);
        _rows.Add(_dRow);
        _rows.Add(_eRow);
        _rows.Add(_fRow);
        _rows.Add(_gRow);
        _rows.Add(_hRow);
        _rows.Add(_iRow);
        _rows.Add(_jRow);
    }
    public void BoardDisplay()
        {
            _aRow.GetBoardRow("A");
            Console.Write(" ");
            _bRow.GetBoardRow("B");
            Console.Write("  ");
            _cRow.GetBoardRow("C");
            Console.Write("   ");
            _dRow.GetBoardRow("D");
            Console.Write("    ");
            _eRow.GetBoardRow("E");
            Console.Write("     ");
            _fRow.GetBoardRow("F");
            Console.Write("      ");
            _gRow.GetBoardRow("G");
            Console.Write("       ");
            _hRow.GetBoardRow("H");
            Console.Write("        ");
            _iRow.GetBoardRow("I");
            Console.Write("         ");
            _jRow.GetBoardRow("J");
            //Console.WriteLine($@"{space} \ \A\{_row[0]}\\{_row[1]}\\{_row[2]}\\{_row[3]}\\{_row[4]}\\{_row[5]}\\{_row[6]}\\{_row[7]}\\{_row[8]}\\{_row[9]}\\");
        }
}