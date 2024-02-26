using System;
using System.ComponentModel;
using System.Reflection;

public class Peg
{
    private string _status;
    private List<int> _position = new List<int>();

    public Peg()
    {
        _status = " ";
    }

    public string GetStatus()
    {
        string status = _status;
        return status;
    }

    public string HitStatus()
    {
        _status = "H";
        return _status;
    }

    public string MissStatus()
    {
        _status = "M";
        return _status;
    }

    public void SetPostion(string letter, int number)
    {
        int letterCoord = 0;
        List<int> coordinates = new List<int>();

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
        number = number - 1;

        _position.Add(letterCoord);
        _position.Add(number);
    }

    public List<int> GetPosition()
    {
        return _position;
    }
}