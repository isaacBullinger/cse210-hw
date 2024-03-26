using System;

public abstract class Player
{
    private string _name;
    private Board _board = new Board();
    private Fleet _fleet = new Fleet();
    private List<Peg> _pegs = new List<Peg>();
    private String[,] _positions = new String[10, 10];

    public void SetName (string name)
    {
        _name = name;
    }

    public String[,] GetPostions()
    {
        return _positions;
    }

    public void SetPositions(String[,] positions)
    {
        _positions = positions;
    }
    
    public abstract void RequestLocation();

    public abstract String[,] PlaceShips();
}