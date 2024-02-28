public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflecting() : base()
    {
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        int time = StartMessage();
        SetTime(time);
    }

    public void DisplayPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        int number = random.Next(1, _prompts.Count);
        string prompt = _prompts[number];

        Console.WriteLine("Consider the following prompt: \r\n");
        Console.Write($" ---{prompt}---\r\n \r\n");
    }

    public void DisplayQuestion()
    {
        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was complete? ");
        _questions.Add("What made this time different than other times when you were not as successful? ");
        _questions.Add("What is your favorite thing about this experience? ");
        _questions.Add("What could you learn from this experience that applies to other situations? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add("How can you keep this experience in mind in the future? ");

        Random random = new Random();
        int number = random.Next(1, _prompts.Count);
        string question = _questions[number];

        Console.Write("> ");
        Console.Write($"{question}\r\n");
    }

    public void RunReflecting()
    {
        Console.WriteLine("Get ready...");
        PauseAnimation(2);
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience:");
        Console.Write("You may begin in: ");
        PauseTimer(3);
        Console.Clear();

        
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetTime());
        while (DateTime.Now < end)
        {
            DisplayQuestion();
            PauseAnimation(10);
        }

        EndMessage();
    }
}