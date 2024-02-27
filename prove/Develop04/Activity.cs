public class Activity
{
    private int _time;
    private string _name;
    private string _description;

    public Activity(int time, string name, string description)
    {
        _time = time;
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _name;
    }

    public int StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\r\n");
        Console.WriteLine($"{_description}\r\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        var time = int.Parse(Console.ReadLine());
        Console.Clear();

        return time;
    }

    public void EndMessage()
    {
        Console.WriteLine("Well done!");
        PauseAnimation();
        Console.WriteLine($"You have completed another {_time} seconds of the {_name} Activity.");
        PauseAnimation();
    }

    public void PauseAnimation()
    {
        for (int i = 0; i < 4; i ++)
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public void PauseTimer(int time)
    {
        for (int i = time; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void RunActivity()
    {

    }
}