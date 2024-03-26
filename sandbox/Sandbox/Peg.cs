using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

public class Peg
{
    private string _status;
    private int _xCoord;
    private int _yCoord;

    public Peg()
    {
        int xCoord = 0;

        Console.Write("Choose a letter (A-J): ");
        string letter = Console.ReadLine();

        if (letter == "A" || letter == "a")
        {
            xCoord = 0;
        }
        else if (letter == "B" || letter == "b")
        {
            xCoord = 1;
        }
        else if (letter == "C" || letter == "c")
        {
            xCoord = 2;
        }
        else if (letter == "D" || letter == "d")
        {
            xCoord = 3;
        }
        else if (letter == "E" || letter == "e")
        {
            xCoord = 4;
        }
        else if (letter == "F" || letter == "f")
        {
            xCoord = 5;
        }
        else if (letter == "G" || letter == "g")
        {
            xCoord = 6;
        }
        else if (letter == "H" || letter == "h")
        {
            xCoord = 7;
        }
        else if (letter == "I" || letter == "i")
        {
            xCoord = 8;
        }
        else if (letter == "J" || letter == "j")
        {
            xCoord = 9;
        }

        Console.Write("Choose a number (0-9): ");
        int yCoord = int.Parse(Console.ReadLine());

        _xCoord = xCoord;
        _yCoord = yCoord;
        _status = "~";
    }

    public string GetStatus()
    {
        return _status;
    }

    public void SetStatus(string status)
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