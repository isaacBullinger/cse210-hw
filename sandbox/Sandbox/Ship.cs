public class Ship
{
    private bool _isSunk;
    private Cell _cell;
    private int _hitPoints;
    private string _name;

    public Ship(Cell cell, int hitPoints, string name)
    {
        _isSunk = false;
        _cell = cell;
        _hitPoints = hitPoints;
        _name = name;
    }

    public void DisplayShip()    
    {
        Console.Write($"{_name} ({_hitPoints} cells)");
    }

    public bool GetIsSunk()
    {
        return _isSunk;
    }

    public Cell GetCell()
    {
        return _cell;
    }

    public string GetName()
    {
        return _name;
    }
}