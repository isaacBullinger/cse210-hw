using System.ComponentModel.DataAnnotations.Schema;

public class Simple : Goal
{
    public Goal SetGoal()
    {
        Goal goal = new Goal();
        goal.SetTypeGoal("SimpleGoal");
        Console.WriteLine("What is the name of your goal? ");
        goal.SetName(Console.ReadLine());
        Console.WriteLine("What is the description? ");
        goal.SetDescription(Console.ReadLine());
        Console.WriteLine("What are the points you wish to assign to this goal?");
        goal.SetPoints(int.Parse(Console.ReadLine()));

        return goal;
    }

    public void PrintGoal(Goal goal)
    {
        Console.WriteLine($"{goal.GetName()} ({goal.GetDescription()}) {goal.GetPoints()}");
    }

    public override bool IsComplete()
    {
        return false;
    }
}