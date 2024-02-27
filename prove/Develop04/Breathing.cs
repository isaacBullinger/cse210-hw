public class Breathing : Activity
{
    public Breathing(int time, string name, string description) : base(time, name, description)
    {
    }

    public void StartBreathing(int time)
    {
        StartMessage();
        int pause = time / 5;

        Console.WriteLine("Get ready...");
        PauseAnimation();
        for (int i = pause / 2; i > 0; i --)
        {
            Console.Write("Breathe in... ");
            PauseTimer(pause);
            Console.Write("Breathe out... ");
            PauseTimer(pause);
            Console.WriteLine();
        }
    }
}