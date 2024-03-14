using System.ComponentModel.DataAnnotations.Schema;

public class Eternal : Goal
{
    public Eternal()
    {
        SetTypeGoal("EternalGoal:");
    }

    public override int RecordEvent()
    {
        int points = int.Parse(GetPoints());
        Console.WriteLine(int.Parse(GetPoints()));
        
        return points;
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string RecordGoal()
    {
        string output = $"{GetTypeGoal()}:~{GetName()}~{GetDescription()}~{GetPoints()}";

        return output;
    }
}