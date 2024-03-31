using System.Collections.Generic;
using System.IO;

class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int requiredTimes;

    public ChecklistGoal(string name, int value, int requiredTimes) : base(name, value)
    {
        this.requiredTimes = requiredTimes;
    }

    public override void MarkComplete()
    {
        timesCompleted++;
        Console.WriteLine($"Completed checklist goal: {Name} ({timesCompleted}/{requiredTimes}). Gained {Value} points.");
        if (timesCompleted == requiredTimes)
        {
            Console.WriteLine($"Bonus for completing {Name} {requiredTimes} times: {Value * 10} points.");
        }
    }

    public override string GetCompletionStatus()
    {
        return $"Completed {timesCompleted}/{requiredTimes} times";
    }
}