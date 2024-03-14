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

    public override string RecordGoal()
    {
        string output = $"{GetTypeGoal()}~{GetName()}~{GetDescription()}~{GetPoints()}~{_bonus}~{_times}~{_completed}";

        return output;
    }
}