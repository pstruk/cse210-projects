// In addition to date, prompt, and journal entry, I also saved the time that the journal entry was created. 
// To help the user know when something had been loaded or saved, I gave feedback comments such as *File has been loaded(saved).
// I did some error handling in the UserInput() during parsing to ensure that an invalid input didn't cause an exception. I gave 
// user feedback if they entered something other than an int. In the LoadFromFile(), I first checked to ensure that the file name 
// existed, and returned a message if it didn't. 
// I used a HashSet to ensure that the PromptGenerator did not give the user duplicate prompts. 

using System;

class Program
{
    static Journal journal = new Journal();
    
    static void Main(string[] args)
    {   
        Console.WriteLine("");
        Console.WriteLine("Welcome to your new Journal Program!");
                
        int choice = 0;

        do
        {
            MenuList();   
            choice = UserInput();
            MenuItemSelector(choice);
        } while (choice != 5);
    } 

    static void MenuList()
    {
        Console.WriteLine("\nPlease select one of the following menu items.");
        Console.WriteLine("MENU:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit \n");
    }

    static int UserInput()
    {   
        bool successful = false;
        int parsedInput = 0;

        while (!successful) 
        {
            Console.Write("What would you like to do? Please select a Menu number: ");
            string input = Console.ReadLine();
            
            successful = int.TryParse(input, out parsedInput);
            if (!successful)
            {
                Console.WriteLine("*Sorry, Try Again. That choice is not on our Menu.");
                Console.WriteLine("*Choose a number from 1-5");
            }
        }
        return parsedInput;
    }

    static void MenuItemSelector(int menuItem) 
    {
        Console.WriteLine("");
        switch (menuItem)
        {
            case 1: //Write
                //journal.DisplayAll();
                journal.WriteEntry();     
                break;
            case 2: //Display
                journal.DisplayAll();
                break;
            case 3: //Load
                Console.Write("Please enter the name of a .txt file to load: ");
                string fileToLoad = Console.ReadLine();
                journal.LoadFromFile(fileToLoad);
                break;
            case 4: //Save
                Console.Write("Please enter a .txt file name to save to: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                break;
            case 5: //Quit
                Console.WriteLine("*Goodbye. See you tomorrow!");
                break;
            default: 
                Console.WriteLine("*Sorry, Try Again. That choice is not on our Menu."); 
                break;
        }
    } 

}