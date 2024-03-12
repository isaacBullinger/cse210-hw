public class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private string _check;
    private int _points = 0;

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

    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }

    public virtual string RecordEvent()
    {
        return _check;
    }

    public virtual bool IsComplete()
    {
        return true;
    }
}