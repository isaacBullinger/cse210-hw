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

    public Status[,] GetPlayerStatuses()
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

    public Status[,] GetOpponentStatuses()
    {
        Status[,] statuses = new Status[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                statuses[i, j] = _opponentCell[i, j].GetStatus();
            }
        }
        return statuses;
    }

    //Polymorphism demonstrated here:
    public abstract void RequestLocation(Status[,] opponentStatuses);

    //Polymorphism demonstrated here:
    public abstract Cell[,] PlaceShips();

    public void CheckLocations(Status[,] opponentCells)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (opponentCells[i, j] == Status.Hit)
                {
                    _playerCell[i, j].SetStatus(Status.Hit);
                    _playerCell[i, j].SetIndicator('H');
                }

                else if (opponentCells[i, j] == Status.Miss)
                {
                    _playerCell[i, j].SetStatus(Status.Miss);
                    _playerCell[i, j].SetIndicator('M');
                }
            }
        }
    }

    public void CheckWin()
    {
        //Checks if all of the ships are destroyed.
    }
}