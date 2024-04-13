public class Fleet
{
    List<Ship> _fleet = new List<Ship>();

    public Fleet()
    {
        Cell cruiserCell = new Cell('O', Status.Cruiser);
        Ship cruiser = new Ship(cruiserCell, 2, "Cruiser");
        _fleet.Add(cruiser);

        Cell destroyerCell = new Cell('O', Status.Destroyer);
        Ship destroyer = new Ship(destroyerCell, 3, "Destroyer");
        _fleet.Add(destroyer);

        Cell submarineCell = new Cell('O', Status.Submarine);
        Ship submarine = new Ship(submarineCell, 3, "Submarine");
        _fleet.Add(submarine);

        Cell battleshipCell = new Cell('O', Status.Battleship);
        Ship battleship = new Ship(battleshipCell, 4, "Battleship");
        _fleet.Add(battleship);

        Cell aircraftCarrierCell = new Cell('O', Status.Aircraft_Carrier);
        Ship aircraftCarrier = new Ship(aircraftCarrierCell, 5, "Aircraft Carrier");
        _fleet.Add(aircraftCarrier);
    }

    public List<Ship> GetFleet()
    {
        return _fleet;
    }
}