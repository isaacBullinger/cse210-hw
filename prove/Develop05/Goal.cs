public class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private string _points;

    public Goal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is the description? ");
        _description = Console.ReadLine();
        Console.WriteLine("What are the points you wish to assign to this goal?");
        _points = Console.ReadLine();
    }

    public string GetTypeGoal()
    {
        return _type;
    }
    public void SetTypeGoal(string type)
    {
        _type = type;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetPoints()
    {
        return _points;
    }
    public void SetPoints(string points)
    {
        _points = points;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string RecordGoal() 
    {
        return "Hello World!";
    }
}