using System;

public abstract class Player
{
    private string _name;
    private Board _board = new Board();
    private List<Ship> _ships = new List<Ship>();
    private List<Peg> _pegs = new List<Peg>();

    public Player()
    {

    }
    
    public abstract int GetLocation();
}