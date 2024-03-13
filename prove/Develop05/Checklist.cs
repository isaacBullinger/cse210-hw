using System.ComponentModel.DataAnnotations;

public class Checklist : Goal
{
    private int _bonus;
    private int _times;
    private int _completed;
    private int _points;

    public Checklist()
    {
        SetTypeGoal("ChecklistGoal:");
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _times = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing the checklist? ");
        _bonus = int.Parse(Console.ReadLine());
        _completed = 0;
    }

    public override int RecordEvent()
    {
        _times = _times + 1;
        _points = int.Parse(GetPoints());

        return _points;
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
}