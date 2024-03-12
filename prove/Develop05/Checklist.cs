public class Checklist : Goal
{
    private int _bonus;
    private int _times;

    public Checklist()
    {
        SetTypeGoal("ChecklistGoal:");
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _times = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing the checklist? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override bool IsComplete()
    {
        return true;
    }
}