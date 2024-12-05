using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMenu();
        
        Console.ReadLine();
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1 -Start breathing activity");
        Console.WriteLine("  2 -Start listing activity"); 
        Console.WriteLine("  3 -Start reflecting activity");
        Console.WriteLine("  4 -Quit ");
        Console.Write("Select a choice from the menu (1-4): ");
    }
}