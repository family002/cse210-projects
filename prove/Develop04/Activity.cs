using System;
using System.Threading;

public abstract class Activity
{
    public int Duration { get; protected set; }

    protected Activity(int duration)
    {
        Duration = duration;
    }

    public abstract void Start();

    public abstract void End();

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);

        Console.WriteLine();
        }
    }
}