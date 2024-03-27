using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

public class Peg
{
    private Status _status;
    private int _xCoord;
    private int _yCoord;

    public Peg(int xCoord, int yCoord)
    {
        _xCoord = xCoord;
        _yCoord = yCoord;
    }

    public Status GetStatus()
    {
        return _status;
    }

    public void SetStatus(Status status)
    {
        _status = status;
    }

    public int GetX()
    {
        return _xCoord;
    }

    public int GetY()
    {
        return _yCoord;
    }
}