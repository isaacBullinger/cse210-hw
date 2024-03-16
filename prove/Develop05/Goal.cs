public class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    
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

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual List<string> RecordGoal() 
    {
        List<string> recorded = new List<string>();
        return recorded;
    }

    public virtual void ReadGoal()
    {
    }
}