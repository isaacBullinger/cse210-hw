public class Listing : Activity
{
    private List<string> _list = new List<string>();
    private List<string> _prompts = new List<string>();
    public Listing()
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        int time = StartMessage();
        SetTime(time);
    }
    public void DisplayPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();
        int number = random.Next(1, _prompts.Count);
        string prompt = _prompts[number];

        Console.WriteLine("List as many responses as you can to the following prompt: \r\n");
        Console.Write($" ---{prompt}---\r\n \r\n");
        Console.WriteLine("You may begin in: ");
        PauseTimer(3);
    }

    public List<string> RunListing()
    {
        Console.WriteLine("Get ready...");
        PauseAnimation(2);
        Console.WriteLine();
        DisplayPrompt();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetTime());
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            _list.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {_list.Count()} items!");

        EndMessage();

        return _list;
    }
}