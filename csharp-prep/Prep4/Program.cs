using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        int number = 1;
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

        // Calculating and Displaying figures
        int sum = numbers.Sum();
        double ave = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {ave}");
        Console.WriteLine($"Max number: {max}");
    }
}