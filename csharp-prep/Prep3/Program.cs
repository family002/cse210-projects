using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string game = "yes";
        Random random = new Random();
        int number = random.Next(1,101);
        while (game == "yes")
            {
                Console.Write("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    game = "no";
                }
            }
    }
}