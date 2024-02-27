public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflecting(int time, string name, string description) : base(time, name, description)
    {
        name = "Reflecting";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        time = 50;
    }
    public string DisplayPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        int number = random.Next(1, _prompts.Count);
        string prompt = _prompts[number];

        return prompt;
    }

    public string DisplayQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();
        int number = random.Next(1, _prompts.Count);
        string question = _questions[number];

        return question;
    }
}