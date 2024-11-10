using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int numSquared = SquareNumber(favNumber);
        DisplayResult(userName, numSquared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        string userName = "";
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        int favNumber = 0;
        Console.Write("Please enter your favorite number: ");
        favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string userName, int numSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numSquared}");
    }
}