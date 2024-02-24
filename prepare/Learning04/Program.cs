using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Allison Rose", "C#");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Allison Rose", "Math", "Section 7.3", "Problems 9-15");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Allison Rose", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}