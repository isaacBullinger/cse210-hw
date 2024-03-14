using System.ComponentModel.DataAnnotations.Schema;

public class Simple : Goal
{
    private string _check;

    public Simple()
    {
        SetTypeGoal("SimpleGoal:");
        _check = "False";
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

    public override string RecordGoal()
    {
        string output = $"{GetTypeGoal()}~{GetName()}~{GetDescription()}~{GetPoints()}~{_check}";

        return output;
    }
}