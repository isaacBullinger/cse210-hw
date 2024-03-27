using System;

public abstract class Player
{
    private string _name;
    private Board _board = new Board();
    private Fleet _fleet = new Fleet();
    private Peg[,] _pegs = new Peg[10, 10];
    private Status[,] _statuses = new Status[10,10];
    private String[,] _positions = new String[10, 10];

    public void SetName (string name)
    {
        _name = name;
    }

    public String[,] GetPostions()
    {
        return _positions;
    }

    public Status[,] GetStatuses()
    {
        return _statuses;
    }

    public void SetStatuses(Status[,] statuses)
    {
        _statuses = statuses;
    }

    //Polymorphism demonstrated here:
    public void SetPositions(String[,] positions)
    {
        _positions = positions;
    }
    
    public abstract void RequestLocation(String[,] positions);

    public abstract String[,] PlaceShips();

}