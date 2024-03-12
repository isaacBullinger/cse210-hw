using System.ComponentModel.DataAnnotations.Schema;

public class Eternal : Goal
{
    private string _check;

    public Eternal()
    {
        SetTypeGoal("EternalGoal:");
    }

    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }
}