using System.ComponentModel.DataAnnotations.Schema;

public class Simple : Goal
{
    private string _check;

    public Simple()
    {
        SetTypeGoal("SimpleGoal:");
    }
    public override bool IsComplete()
    {
        return true;
    }
}