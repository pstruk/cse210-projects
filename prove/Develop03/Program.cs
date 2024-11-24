//I created a ScriptureLibrary to work with my scripture memorizer program to add a creativity component and to exceed the requirements.

using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary verse = new ScriptureLibrary();  
        Scripture scripture = verse.GetScripture();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress the Enter key to continue, or type 'quit' to finish:\n");
            
            if (scripture.IsCompletelyHidden() == true)
            {
                Environment.Exit(0);
            }                      
            
            string userInput = Console.ReadLine();
            
            switch (userInput.ToLower())
            {
                case "": 
                    scripture.HideRandomWords(3);    // Removes 3 random words
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That is not a valid input. To exit type the word: quit");
                    Console.ReadLine();
                    break;              
            } 
        }
    }
} 