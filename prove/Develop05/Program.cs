// For my creativity component, I added another kind of mindfulness activity called an AffirmationActivity 
// where you repeat each affirming statement 3 times. I animated my prompts by splitting the words up 
// into a list and then displaying them one at a time with a slight pause between them to improve readability.
using System;

class Program
{
    static BreathingActivity _breathing = new BreathingActivity();
    static ReflectingActivity _reflecting = new ReflectingActivity();
    static ListingActivity _listing = new ListingActivity();
    static AffirmationActivity _affirmation = new AffirmationActivity();

    static void Main(string[] args)
    {
        Console.Clear();
        int menuSelection;

        do 
        {    
            menuSelection = 0;
            while (menuSelection == 0)
            {
                DisplayMenu();
            
                string userChoice = Console.ReadLine();
                if(!int.TryParse(userChoice, out menuSelection))
                {
                    Console.WriteLine("\nIncorrect Input. You must enter a number from 1-5.");
                }
            }
            MenuSelector(menuSelection);
            
        } while (menuSelection != 5);
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1 -Start breathing activity");
        Console.WriteLine("  2 -Start reflecting activity"); 
        Console.WriteLine("  3 -Start listing activity");
        Console.WriteLine("  4 -Start affirmation activity");
        Console.WriteLine("  5 -Quit");
        Console.Write("Select a choice from the menu (1-5): ");
    }

    static void MenuSelector(int menuSelection)
    {
        int menuItem = menuSelection;
        
        switch (menuItem)
        {
            case 1: //breathing
                _breathing.Run();
                break;
            case 2: //reflecting
                _reflecting.Run();
                break;
            case 3: //listing
                _listing.Run();
                break;
            case 4: //affirmations
                _affirmation.Run();
                break;
            case 5: //quit
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\nWrong input. Please select a number from 1-5");
                break;
        }
    }
}