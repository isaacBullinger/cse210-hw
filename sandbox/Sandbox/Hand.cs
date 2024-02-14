using System;

public class Hand
{

    public List<Card> _card = new List<Card>();
    public string _name;

    public void Display()
    {
        foreach (Card card in _card)
        {
            card.Display();
        }
    }

}