using System;

public abstract class Player
{
    private string _name;
    private Cell[,] _playerCell = new Cell[10, 10];
    private Cell[,] _opponentCell = new Cell[10, 10];
    
    public Player()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                _opponentCell[i, j] = new Cell();
            }
        }
    }

    public void SetName (string name)
    {
        _name = name;
    }

    public Cell[,] GetPlayerCells()
    {
        return _playerCell;
    }

    public void SetPlayerCells(Cell[,] cells)
    {
        _playerCell = cells;
    }

    public Cell[,] GetOpponentCells()
    {
        return _opponentCell;
    }

    public void SetOpponentCells(Cell[,] cells)
    {
        _opponentCell = cells;
    }


    public Char[,] GetPlayerIndicators()
    {
        Char[,] indicators = new char[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                indicators[i, j] = _playerCell[i, j].GetIndicator();
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
                indicators[i, j] = _opponentCell[i, j].GetIndicator();
            }
            Console.WriteLine();
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
                statuses[i, j] = _playerCell[i, j].GetStatus();
            }
        }
        return statuses;
    }

    //Polymorphism demonstrated here:
    public abstract void RequestLocation(Status[,] statuses);

    public abstract Cell[,] PlaceShips();

    public Char[,] CheckLocations(Char[,] cells)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (_playerCell[i, j].GetStatus() is Status.Aircraft_Carrier or Status.Battleship or Status.Cruiser or Status.Destroyer or Status.Submarine)
                {
                    _opponentCell[i, j].SetStatus(Status.Hit);
                    _opponentCell[i, j].SetIndicator('H');
                }

                else if (_playerCell[i, j].GetStatus() == Status.Empty)
                {
                    _opponentCell[i, j].SetStatus(Status.Miss);
                    _opponentCell[i, j].SetIndicator('M');
                }
            }
        }
        Char [,] indicators = GetOpponentIndicators();
        return indicators;
    }
}