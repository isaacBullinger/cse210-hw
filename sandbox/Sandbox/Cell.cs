public class Cell
{
    private char _indicator;
    private Status _status;

    public Cell()
    {
        _indicator = ' ';
        _status = Status.Empty;
    }

    public Cell(char indicator, Status status)
    {
        _indicator = indicator;
        _status = status;
    }

    public char GetIndicator()
    {
        return _indicator;
    }

    public Status GetStatus()
    {
        return _status;
    }
}