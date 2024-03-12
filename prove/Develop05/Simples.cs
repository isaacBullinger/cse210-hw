using System.ComponentModel.DataAnnotations.Schema;

public class Simple : Goal
{
    private string _check;

    public Simple()
    {
        SetTypeGoal("SimpleGoal:");
        _check = "False";
    }

    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return true;
    }
}