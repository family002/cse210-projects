using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string user = PromptUserName();
        int number = PromptUserNumber();
        int sqnum = SquareNumber(number);
        DisplayResult(user, sqnum);
    }

    // Functions
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int num)
    {
        int sqnum = num*num;
        return sqnum;
    }
    static void DisplayResult(string user, int sqnum)
    {
        Console.WriteLine($"{user}, the square of your number is {sqnum}.");
    }
}