public class ReflectingActivity : Activity
{
    private readonly string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Reflection Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("Please enter the duration of this activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        Random rand = new Random();
        int promptIndex = rand.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);
        ShowSpinner(3);

        for (int i = 0; i < Duration; i++)
        {
            int questionIndex = rand.Next(questions.Length);
            Console.WriteLine(questions[questionIndex]);
            ShowSpinner(3);
        }
    }

    public override void End()
    {
        Console.WriteLine("Good job! You've completed the Reflection Activity.");
        ShowSpinner(3);
    }
}