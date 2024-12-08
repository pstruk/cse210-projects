using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private List<string> _animateStrings = new List<string>();
    
    public Activity()
    {
        _animateStrings.Add("|");
        _animateStrings.Add("/");  
        _animateStrings.Add("-");
        _animateStrings.Add("\\");
        _animateStrings.Add("|");
        _animateStrings.Add("/");
        _animateStrings.Add("-");
        _animateStrings.Add("\\");
    }

    protected void DisplayStartingMessage()  
    {
        Console.WriteLine($"\nWelcome to the {_name}!\n");
        Console.WriteLine($"{_description}\n");
        
        _duration = 0;

        while (_duration == 0)
        {
            Console.Write("How long, in seconds, would you like for your session to last? ");
            string inputDuration = Console.ReadLine();
            
            if(!int.TryParse(inputDuration, out _duration))
            {
                Console.WriteLine("\nIncorrect Input. You must enter a number larger than 0.\n");
            }
        }
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds) 
    {
        foreach (string s in _animateStrings)
        {
            Console.Write(s);
            Thread.Sleep((seconds * 1000) / 8);
            Console.Write("\b \b");
        }
    }

    protected void ShowCountDown(int seconds)  
    {
        for (int i = seconds; i > 0; i--) 
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void ShowDots(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
        Console.Write(" . ");
        Thread.Sleep(1000);
        }
    }
}