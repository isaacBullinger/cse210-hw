using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

public class Peg
{
    private char _indicator;
    private Status _status;

    public Peg()
    {
        _indicator = '~';
        _status = Status.Empty;
    }

    public char GetIndicator()
    {
        return _indicator;
    }

    public void SetIndicator(char indicator)
    {
        _indicator = indicator;
    }

    public Status GetStatus()
    {
        return _status;
    }

    public void SetStatus(Status status)
    {
        _status = status;
    }
}