using System.Collections.Generic;
using System.IO;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value) { }

    public override void MarkComplete()
    {
        Console.WriteLine($"Completed simple goal: {Name}. Gained {Value} points.");
    }

    public override string GetCompletionStatus()
    {
        return "[X]";
    }
}