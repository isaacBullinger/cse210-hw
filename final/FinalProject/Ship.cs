using System;
using System.Diagnostics;
using System.Reflection;

public class Ship
{
    private string _name;
    private Status _status;
    private bool _isSunk;
    private int _hitPoints;

    public Ship(int hitPoints, string name, Status status)
    {
        _name = name;
        _isSunk = false;
        _hitPoints = hitPoints;
        _status = status;
    }

    public void DisplayShip(int number)
    {
        Console.WriteLine($"{number}. {_name} ({_hitPoints} slots)");
    }

    public string GetName()
    {
        return _name;
    }

    public Status GetStatus()
    {
        return _status;
    }

    public void SetStatus(Status status)
    {
        _status = status;
    }

    public int GetHP()
    {
        return _hitPoints;
    }

    public bool GetIsSunk()
    {
        return _isSunk;
    }

    public void SetIsSunk(bool isSunk)
    {
        _isSunk = isSunk;
    }
}