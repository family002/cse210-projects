using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public List<string> _prompts;

    public Journal()
    {
        _entries = new List<Entry>();
        PromptGenerator();
    }

    public void Write(string response)
    {
        string randomPrompt = RandomPrompt();
        Entry newEntry = new Entry(DateTime.Now, randomPrompt, response);
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void Save(string fileName)
    {
        string fullPath = Path.Combine("saves", fileName);
        using (StreamWriter sw = new StreamWriter(fullPath, true))
        {
            foreach (var entry in _entries)
            {
                sw.WriteLine($"{entry.DateTime}, {entry.Prompt}, {entry.Response}");
            }
        }
    }

    public void Load(string fileName)
    {
        _entries.Clear();
        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string[] entryData = sr.ReadLine().Split(',');
                    DateTime date = DateTime.Parse(entryData[0]);
                    string prompt = entryData[1];
                    string response = entryData[2];
                    _entries.Add(new Entry(date, prompt, response));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

    public void PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the highlight of your day?",
            "Describe a challenge you overcame today.",
            "What are you grateful for?",
            "Write about a dream or goal you have.",
            "Discuss something you learned recently.",
            "Describe a moment when you felt proud of yourself.",
            "What is a hobby or activity that brings you joy?",
            "Reflect on a quote or saying that inspires you.",
            "Discuss a skill or talent you would like to develop.",
            "Write about a place you'd like to visit and why."
        };
    }

    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}