using System.ComponentModel.DataAnnotations.Schema;

public class Eternal : Goal
{
    public Eternal()
    {
        SetTypeGoal("EternalGoal:");
    }

    public Eternal(string name, string description, string points) : base(name, description, points)
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

    public override List<string> RecordGoal()
    {
        List<string> output = new List<string>();
        output.Add(GetTypeGoal());
        output.Add(GetName());
        output.Add(GetDescription());
        output.Add(GetPoints());

        return output;
    }
}