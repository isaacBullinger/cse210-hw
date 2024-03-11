using System;
using System.Reflection;

class Ship
{
    bool _isSunk;
    int _hitPoints;
    bool _isHorizontal;

    public Ship(int hitPoints, bool isHorizontal)
    {
        _isSunk = false;
        _hitPoints = hitPoints;
        _isHorizontal = isHorizontal;
    }

    public int GetHP()
    {
        return _hitPoints;
    }

    public void ShipCursor()
    {
        Console.Write("O");
        Thread.Sleep(300);
        Console.Write("\b \b");
        Thread.Sleep(300);
    }
}