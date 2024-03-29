using System;

public abstract class Player
{
    private string _name;
    private Peg[,] _playerPeg = new Peg[10, 10];
    private Peg[,] _opponentPeg = new Peg[10, 10];
    
    public Player()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                _opponentPeg[i, j] = new Peg();
            }
        }
    }

    public void SetName (string name)
    {
        _name = name;
    }

    public Peg[,] GetPlayerPegs()
    {
        return _playerPeg;
    }

    public void SetPlayerPegs(Peg[,] pegs)
    {
        _playerPeg = pegs;
    }

    public Peg[,] GetOpponentPegs()
    {
        return _playerPeg;
    }

    public void SetOpponentPegs(Peg[,] pegs)
    {
        _opponentPeg = pegs;
    }


    public Char[,] GetPlayerIndicators()
    {
        Char[,] indicators = new char[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                indicators[i, j] = _playerPeg[i, j].GetIndicator();
            }
        }
        return indicators;
    }

    public Char[,] GetOpponentIndicators()
    {
        Char[,] indicators = new char[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                indicators[i, j] = _opponentPeg[i, j].GetIndicator();
            }
        }
        return indicators;
    }

    public Status[,] GetStatuses()
    {
        Status[,] statuses = new Status[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                statuses[i, j] = _opponentPeg[i, j].GetStatus();
            }
        }
        return statuses;
    }

    //Polymorphism demonstrated here:
    public abstract void RequestLocation(Status[,] statuses);

    public abstract Peg[,] PlaceShips();

    public Char[,] CheckLocations()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (_playerPeg[i, j].GetStatus() is Status.Aircraft_Carrier or Status.Battleship or Status.Cruiser or Status.Destroyer or Status.Submarine)
                {
                    _opponentPeg[i, j].SetStatus(Status.Hit);
                    _opponentPeg[i, j].SetIndicator('H');
                }

                else if (_playerPeg[i, j].GetStatus() == Status.Empty)
                {
                    _opponentPeg[i, j].SetStatus(Status.Miss);
                    _opponentPeg[i, j].SetIndicator('M');
                }
            }
        }
        Char [,] indicators = GetOpponentIndicators();
        return indicators;
    }
}