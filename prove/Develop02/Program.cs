using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program!");
        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Delete\n6. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = journal.RandomPrompt();
                    Console.WriteLine(randomPrompt);
                    string response = Console.ReadLine();
                    journal.Write(response);
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter a filename to load from: ");
                    string loadFileName = Console.ReadLine();
                    journal.Load(loadFileName);
                    break;

                case "4":
                    Console.Write("Enter a filename to save to: ");
                    string saveFileName = Console.ReadLine();
                    journal.Save(saveFileName);
                    break;

                case "5":
                    Console.Write("Enter a filename to delete: ");
                    string deleteFileName = Console.ReadLine();
                    DeleteFile.Delete(deleteFileName);
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please choose  a number 1 through 5.");
                    break;
            }
        }
    }
}
