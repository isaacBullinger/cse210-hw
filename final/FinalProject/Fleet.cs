using System.ComponentModel.Design;
using System.Data;
using System.Runtime.InteropServices;

public class Fleet
{
    private Ship _aircraftCarrier = new Ship(5, "Aircraft Carrier", Status.Aircraft_Carrier);
    private Ship _battleship = new Ship(4, "Battleship", Status.Battleship);
    private Ship _destroyer = new Ship(3, "Destroyer", Status.Destroyer);
    private Ship _submarine = new Ship(3, "Submarine", Status.Submarine);
    private Ship _cruiser = new Ship(2, "Cruiser", Status.Cruiser);
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