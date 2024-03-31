using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    public string Name { get; }
    public int Value { get; }

    protected Goal(string name, int value)
    {
        Name = name;
        Value = value;
    }

    public abstract void MarkComplete();

    public abstract string GetCompletionStatus();
}
