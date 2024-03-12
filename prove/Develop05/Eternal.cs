using System.ComponentModel.DataAnnotations.Schema;

public class Eternal : Goal
{
    private string _check;

    public Eternal()
    {
        SetTypeGoal("EternalGoal:");
        _check = "False";
    }
    public override bool IsComplete()
    {
        return false;
    }
}