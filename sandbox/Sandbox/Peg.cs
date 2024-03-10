using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

public class Peg
{
    private string _status;
    private int _x;
    private int _y;

    public Peg()
    {
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

    public void SetYPosition()
    {
        int letterCoord = 0;

        Console.Write("Choose a letter (A-J): ");
        string letter = Console.ReadLine();

        if (letter == "A" || letter == "a")
        {
            letterCoord = 0;
        }
        else if (letter == "B" || letter == "b")
        {
            letterCoord = 1;
        }
        else if (letter == "C" || letter == "c")
        {
            letterCoord = 2;
        }
        else if (letter == "D" || letter == "d")
        {
            letterCoord = 3;
        }
        else if (letter == "E" || letter == "e")
        {
            letterCoord = 4;
        }
        else if (letter == "F" || letter == "f")
        {
            letterCoord = 5;
        }
        else if (letter == "G" || letter == "g")
        {
            letterCoord = 6;
        }
        else if (letter == "H" || letter == "h")
        {
            letterCoord = 7;
        }
        else if (letter == "I" || letter == "i")
        {
            letterCoord = 8;
        }
        else if (letter == "J" || letter == "j")
        {
            letterCoord = 9;
        }

        _x = letterCoord;
    }

    public int GetY()
    {
        return _y;
    }

    public void SetXPosition()
    {
        Console.Write("Choose a number (0-9): ");
        int number = int.Parse(Console.ReadLine());
        
        _y = number;
    }

    public int GetX()
    {
        return _x;
    }
}