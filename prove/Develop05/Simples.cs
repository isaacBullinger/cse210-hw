using System.ComponentModel.DataAnnotations.Schema;

public class Simple : Goal
{
    private string _check;
    private int _points;

    public Simple()
    {
        SetTypeGoal("SimpleGoal:");
        _check = "False";
    }

    public override int RecordEvent()
    {
        _check = "True";
        _points = int.Parse(GetPoints());

        return _points;
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
}