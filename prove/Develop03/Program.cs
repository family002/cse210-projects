using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture("Proverbs", 3, 5, "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
        };

        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        
        while (!selectedScripture.AllWordsHidden)
        {
            Console.Clear();
            selectedScripture.HideRandomWord();
            Console.WriteLine(selectedScripture);
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
        }
    }
}