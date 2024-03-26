using System;
using System.Reflection;

public class Ship
{
    string _name;
    bool _isSunk;
    int _hitPoints;

    public Ship(int hitPoints, string name)
    {
        _name = name;
        _isSunk = false;
        _hitPoints = hitPoints;
    }

    public void DisplayShip(int number)
    {
        Console.WriteLine($"{number}. {_name} ({_hitPoints} slots)");
    }

    public int GetHP()
    {
        return _hitPoints;
    }
}