using System;

public class Display
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

    public Display()
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

    public void UserDisplay()
    {
        _aRow.GetDisplayRow("A");
        _bRow.GetDisplayRow("B");
        _cRow.GetDisplayRow("C");
        _dRow.GetDisplayRow("D");
        _eRow.GetDisplayRow("E");
        _fRow.GetDisplayRow("F");
        _gRow.GetDisplayRow("G");
        _hRow.GetDisplayRow("H");
        _iRow.GetDisplayRow("I");
        _jRow.GetDisplayRow("J");
    }

    public void CheckDisplayRows()
    {
        
    }
}