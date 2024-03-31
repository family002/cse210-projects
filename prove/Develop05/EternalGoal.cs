using System.Collections.Generic;
using System.IO;

class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override void MarkComplete()
    {
        Console.WriteLine($"Recorded event for eternal goal: {Name}. Gained {Value} points.");
    }

    public override string GetCompletionStatus()
    {
        return "[ ]";
    }
}