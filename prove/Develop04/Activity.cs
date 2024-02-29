public class Activity
{
    private int _time;
    private string _name;
    private string _description;

    public Activity()
    {
        _time = 30;
        _name = "Generic Name";
        _description = "Put description here...";
    }

    public void SetTime(int time)
    {
        _time = time;
    }

    public int GetTime()
    {
        return _time;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
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
        Console.WriteLine("\r\nWell done!");
        PauseAnimation(2);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_name} Activity.");
        PauseAnimation(2);
        Console.Clear();
    }

    public void PauseAnimation(int seconds)
    {
        List<string> animations = new List<string>();
        animations.Add("-");
        animations.Add(@"\");
        animations.Add("|");
        animations.Add("/");
        
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);
        
        int i = 0;

        while (DateTime.Now < end)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count())
            {
                i = 0;
            }
        }
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
}