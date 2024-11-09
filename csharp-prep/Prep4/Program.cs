using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userInput = -1; 

        do
        {
            Console.Write("Enter Number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput !=0)
            {
                numbers.Add(userInput);
            }

        } while (userInput !=0);

        //calculate the sum of all the userInput numbers
        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}"); 

        // calculate the average of all userInput numbers
        // we need to make a variable a float or double, so it does floating point division that gives decimals.
        int listCount = numbers.Count;
        
        double average = ((double)sum) / listCount;
        Console.WriteLine($"The average is: {average}");

        //find the highest/max number in the users list
        int maxNumber = 0;
        
        foreach (int number in numbers)
        {
           if (number > maxNumber)
           {
               maxNumber = number;
           }
        }
        Console.WriteLine($"The largest number is: {maxNumber}");

        // Other OPTIONS: To get the sum, average + highest number using the built in functions:
        // int listTotal = numbers.Sum();
        // Console.WriteLine($"The sum is: {listTotal}");

        // float listAverage = ((float)listTotal / numbers.Count);           
        // Console.WriteLine($"The average is: {listAverage}");
        
        // max variation 1:
        // int maxNumber = numbers.Max();
        // Console.WriteLine($"The largest number is: {maxNumber}");

        // Or max variation 2 using Sort() for ascending order
        // numbers.Sort();
        // maxNumber = numbers[numbers.Count - 1];
        // Console.WriteLine($"The largest number is: {maxNumber}");
    
    }
}