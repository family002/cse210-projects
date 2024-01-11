using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        string letter = "";

        if (grade < 60)
        {
            Console.WriteLine("Sorry, you failed the class.");
        }
        else if (grade >= 60 && grade <= 69)
        {
            letter = "D";
            Console.WriteLine($"You got a {letter}. You did not pass the class.");
        }
        else if (grade >= 70 && grade <= 79)
        {
            Console.WriteLine("Congrats! You passed the class with a C!");
        }
        else if (grade >= 80 && grade <= 89)
        {
            Console.WriteLine("Congrats! You passed the class with a B!");
        }
        else if (grade >= 90)
        {
            Console.WriteLine("Congrats! You passed the class with an A!");
        }
        
    }
}