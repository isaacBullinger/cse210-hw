using System.ComponentModel.DataAnnotations;

public class Checklist : Goal
{
    private int _bonus;
    private int _times;
    private int _completed;
    
    public Checklist()
    {
        SetTypeGoal("ChecklistGoal:");
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _completed = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing the checklist? ");
        _bonus = int.Parse(Console.ReadLine());
        _times = 0;
    }

    public Checklist(string name, string description, string points, int completed, int bonus, int times) : base(name, description, points)
    {
        SetTypeGoal("ChecklistGoal:");
        _completed = completed;
        _bonus = bonus;
        _times = times;
    }

    public int GetTimes()
    {
        return _times;
    }

    public int GetCompleted()
    {
        return _completed;
    }

    public override int RecordEvent()
    {
        _times = _times + 1;
        int points = int.Parse(GetPoints());
        Console.WriteLine(int.Parse(GetPoints()));
        
        if (IsComplete() == true)
        {
            points = points + _bonus;
        }

        return points;
    }

    public override bool IsComplete()
    {
        if (_times == _completed)
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
        output.Add(_bonus.ToString());
        output.Add(_times.ToString());
        output.Add(_completed.ToString());

        return output;
    }
}