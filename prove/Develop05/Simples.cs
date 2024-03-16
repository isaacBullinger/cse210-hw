using System.ComponentModel.DataAnnotations.Schema;

public class Simple : Goal
{
    private string _check;

    public Simple()
    {
        SetTypeGoal("SimpleGoal:");
        _check = "False";
    }

    public Simple(string name, string description, string points, string check) : base(name, description, points)
    {
        SetTypeGoal("SimpleGoal:");
        _check = check;
    }

    public override int RecordEvent()
    {
        _check = "True";
        int points = int.Parse(GetPoints());
        Console.WriteLine(int.Parse(GetPoints()));

        return points;
    }
    public override bool IsComplete()
    {
        if (_check == "True")
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public override List<string> RecordGoal()
    {
        List<string> output = new List<string>();

        output.Add(GetTypeGoal());
        output.Add(GetName());
        output.Add(GetDescription());
        output.Add(GetPoints());
        output.Add(_check);

        return output;
    }
}