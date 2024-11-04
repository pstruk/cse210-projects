using System;
using System.Security.Authentication.ExtendedProtection;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userPercentageInput = Console.ReadLine();
        int gradePercentage = int.Parse(userPercentageInput);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A"; 
        }
        else if (gradePercentage >= 80)
        {
            letter = "B"; 
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed your course.");
        }
        else
        {
            Console.WriteLine("Sorry that you didn't pass. You'll do better next time.");
        }

    }
}