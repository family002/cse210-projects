public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Please enter the duration of this activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        Console.WriteLine("Begin breathing:");
        for (int i = 0; i < Duration; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }
            Thread.Sleep(1000);
        }
    }

    public override void End()
    {
        Console.WriteLine("Good job! You've completed the Breathing Activity for {0} seconds.", Duration);
        ShowSpinner(3);
    }
}