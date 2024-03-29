using System.ComponentModel;

public enum Status
{
    //[Description ("O")]
    Cruiser = 0,
    //[Description ("O")]
    Destroyer = 1,
    //[Description ("O")]
    Submarine = 2,
    //[Description ("O")]
    Battleship = 3,
    //[Description ("O")]
    Aircraft_Carrier = 4,
    //[Description ("~")]
    Empty,
    //[Description ("H")]
    Hit,
    //[Description ("M")]
    Miss,
    //[Description ("S")]
    Sink
}