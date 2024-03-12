public class Checklist : Goal
{
    private int _bonus;
    private int _times;
    private int _completed;

    public Checklist()
    {
        SetTypeGoal("ChecklistGoal:");
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _times = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing the checklist? ");
        _bonus = int.Parse(Console.ReadLine());
        _completed = 0;
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return true;
    }
}