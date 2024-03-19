using System;
using System.Reflection;

class Ship
{
    bool _isSunk;
    int _hitPoints;
    int _xCoord;
    int _yCoord;

    public Ship(int hitPoints)
    {
        _isSunk = false;
        _hitPoints = hitPoints;
    }

    public int GetHP()
    {
        return _hitPoints;
    }
}