using System;
using System.ComponentModel;

public abstract class Player
{
    private string _name;
    private string _opponentName;
    private List<Ship> _ships = new List<Ship>();
    private Cell[,] _playerCell = new Cell[10, 10];
    private Cell[,] _opponentCell = new Cell[10, 10];
    private bool _aircraftMessage = false;
    private bool _battleshipMessage = false;
    private bool _destroyerMessage = false;
    private bool _submarineMessage = false;
    private bool _cruiserMessage = false;

    
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

    public List<Ship> GetFleet()
    {
        return _ships;
    }

    public void SetFleet(List<Ship> fleet)
    {
        _ships = fleet;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName (string name)
    {
        _name = name;
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

    public void CheckShips(Status[,] opponentStatuses, string name)
    {
        int aircraftCount = 0;
        int battleshipCount = 0;
        int destroyerCount = 0;
        int submarineCount = 0;
        int cruiserCount = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (_playerCell[i, j].GetStatus() == Status.Aircraft_Carrier)
                {
                    aircraftCount++;
                }

                if (_playerCell[i, j].GetStatus() == Status.Battleship)
                {
                    battleshipCount++;
                }

                if (_playerCell[i ,j].GetStatus() == Status.Destroyer)
                {
                    destroyerCount++;
                }

                if (_playerCell[i, j].GetStatus() == Status.Submarine)
                {
                    submarineCount++;
                }

                if (_playerCell[i, j].GetStatus() == Status.Cruiser)
                {
                    cruiserCount++;
                }
            }
        }

        if (aircraftCount == 0 && _aircraftMessage == false)
        {
            foreach (Ship ship in _ships)
            {
                if (ship.GetStatus() == Status.Aircraft_Carrier)
                {
                    ship.SetIsSunk(true);
                    ship.SetStatus(Status.Sink);
                }
            }
            Console.WriteLine($"{name} sunk the {_name}'s aircraft carrier!");
            _aircraftMessage = true;
        }

        if (battleshipCount == 0 && _battleshipMessage == false)
        {
            foreach (Ship ship in _ships)
            {
                if (ship.GetStatus() == Status.Battleship)
                {
                    ship.SetIsSunk(true);
                    ship.SetStatus(Status.Sink);
                }
            }
            Console.WriteLine($"{name} sunk the {_name}'s battleship!");
            _battleshipMessage = true;
        }
        
        if (destroyerCount == 0 && _destroyerMessage == false)
        {
            foreach (Ship ship in _ships)
            {
                if (ship.GetStatus() == Status.Destroyer)
                {
                    ship.SetIsSunk(true);
                    ship.SetStatus(Status.Sink);
                }
            }
            Console.WriteLine($"{name} sunk the {_name}'s destroyer!");
            _destroyerMessage = true;
        }
        
        if (submarineCount == 0 && _submarineMessage == false)
        {
            foreach (Ship ship in _ships)
            {
                if (ship.GetStatus() == Status.Submarine)
                {
                    ship.SetIsSunk(true);
                    ship.SetStatus(Status.Sink);
                }
            }
            Console.WriteLine($"{name} sunk the {_name}'s submarine!");
            _submarineMessage = true;
        }
        
        if (cruiserCount == 0 && _cruiserMessage == false)
        {
            foreach (Ship ship in _ships)
            {
                if (ship.GetStatus() == Status.Cruiser)
                {
                    ship.SetIsSunk(true);
                    ship.SetStatus(Status.Sink);
                }
            }
            Console.WriteLine($"{name} sunk the {_name}'s cruiser!");
            _cruiserMessage = true;
        }
    }

    public bool CheckWin()
    {
        foreach (Cell cell in _playerCell)
        {
            if (cell.GetIndicator() == 'O')
            {
                return false;
            }
        }
        return true;
    }
}