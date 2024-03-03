public class ListingActivity : Activity
{
    private readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Please enter the duration of this activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        Random rand = new Random();
        int promptIndex = rand.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);
        ShowSpinner(3);

        Console.WriteLine("Start listing items:");
        int itemCount = 0;
        while (Duration > 0)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
            {
                break;
            }
            itemCount++;
            Duration--;
        }
        Console.WriteLine("You listed {0} items.", itemCount);
    }

    public override void End()
    {
        Console.WriteLine("Good job! You've completed the Listing Activity.");
        ShowSpinner(3);
    }
}