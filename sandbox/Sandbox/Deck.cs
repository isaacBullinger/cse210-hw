using System;

public class Deck
{

    public string _suit;
    public int _number;

    public void Display()
    {
        Console.WriteLine($"{_number} of {_suit}");
    }

}