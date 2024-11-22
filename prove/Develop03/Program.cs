using System;

class Program
{
    
    static void Main(string[] args)
    {
        string scriptureVerse = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " + 
                                "In all thy ways acknowledge him, and he shall direct thy paths.";

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, scriptureVerse);


              
        
    }
}