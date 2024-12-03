using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1-setting up and testing the base class
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary() + "\n");

        // Part 2-setting up and testing the MathAssignment derivative class
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList() + "\n");

        // Part 3-setting up and testing the WritingAssignment derivative class
        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}