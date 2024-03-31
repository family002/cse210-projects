using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        Console.WriteLine($"Added new goal: {goal.Name}");
    }

    public void MarkGoalComplete(string name)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == name)
            {
                goal.MarkComplete();
                return;
            }
        }
        Console.WriteLine($"Goal '{name}' not found.");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine($"- {goal.Name} {goal.GetCompletionStatus()}");
        }
    }

    public void SaveGoals(string filename)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var goal in goals)
                {
                    string line = $"{goal.GetType().Name},{goal.Name},{goal.Value}";
                    sw.WriteLine(line);
                }
                Console.WriteLine("Goals saved successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals(string filename)
    {
        try
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string goalType = parts[0];
                        string name = parts[1];
                        int value = int.Parse(parts[2]);

                        Goal goal;
                        switch (goalType)
                        {
                            case nameof(SimpleGoal):
                                goal = new SimpleGoal(name, value);
                                break;
                            case nameof(EternalGoal):
                                goal = new EternalGoal(name, value);
                                break;
                            case nameof(ChecklistGoal):
                                goal = new ChecklistGoal(name, value, 0);
                                break;
                            default:
                                continue;
                        }
                        goals.Add(goal);
                    }
                }
                Console.WriteLine("Goals loaded successfully.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Goals file not found. No goals loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}
