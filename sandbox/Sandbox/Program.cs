using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Card card1 = new Card();
        card1._suit = "Spades";
        card1._number = 13;

        Card card2 = new Card();
        card2._suit = "Hearts";
        card2._number = 2;

        Card card3 = new Card();
        card3._suit = "Diamonds";
        card3._number = 3;

        Card card4 = new Card();
        card4._suit = "Clubs";
        card4._number = 4;

        Card card5 = new Card();
        card5._suit = "Clubs";
        card5._number = 5;

        Hand hand1 = new Hand();
        hand1._name = "Isaac";

        hand1._card.Add(card1);
        hand1._card.Add(card2);
        hand1._card.Add(card3);
        hand1._card.Add(card4);
        hand1._card.Add(card5);

        hand1.Display();

    }
}