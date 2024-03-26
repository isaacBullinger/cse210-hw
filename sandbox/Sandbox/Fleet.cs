using System.ComponentModel.Design;
using System.Data;
using System.Runtime.InteropServices;

public class Fleet
{
    private Ship _aircraftCarrier = new Ship(5, "Aircraft Carrier");
    private Ship _battleship = new Ship(4, "Battleship");
    private Ship _submarine = new Ship(3, "Submarine");
    private Ship _destroyer = new Ship(3, "Destroyer");
    private Ship _cruiser = new Ship(2, "Cruiser");
    private List<Ship> _ships = new List<Ship>();
    
    public Fleet()
    {
        _ships.Add(_cruiser);
        _ships.Add(_destroyer);
        _ships.Add(_submarine);
        _ships.Add(_battleship);
        _ships.Add(_aircraftCarrier);
    }

    public List<Ship> GetFleet()
    {
        return _ships;
    }
}