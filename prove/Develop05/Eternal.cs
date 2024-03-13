using System.ComponentModel.DataAnnotations.Schema;

public class Eternal : Goal
{
    private int _points;
    public Eternal()
    {
        SetTypeGoal("EternalGoal:");
    }

    public override int RecordEvent()
    {
        _points = int.Parse(GetPoints());
        
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }
}