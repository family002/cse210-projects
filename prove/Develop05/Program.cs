using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string filename = "goals.csv";

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    goalManager.SaveGoals(filename);
                    break;
                case "4":
                    goalManager.LoadGoals(filename);
                    break;
                case "5":
                    RecordEvent(goalManager);
                    break;
                case "6":
                    exit = true;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("\nCreate New Goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal value: ");
        int value = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, value));
                break;
            case "2":
                goalManager.AddGoal(new EternalGoal(name, value));
                break;
            case "3":
                Console.Write("Enter required times: ");
                int requiredTimes = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, value, requiredTimes));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.Write("Enter the name of the goal to mark as completed: ");
        string goalName = Console.ReadLine();
        goalManager.MarkGoalComplete(goalName);
    }
}