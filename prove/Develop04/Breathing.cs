public class Breathing : Activity
{
    public Breathing() : base()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int time = StartMessage();
        SetTime(time);
    }

    public void RunBreathing()
    {
        int pause = 5;

        Console.WriteLine("Get ready...");
        PauseAnimation(2);

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetTime());
        while (DateTime.Now < end)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            PauseTimer(pause);
            Console.Write("Breathe out... ");
            PauseTimer(pause);
        }

        EndMessage();
    }
}