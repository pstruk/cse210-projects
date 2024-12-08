using System;
using System.Collections.Generic;

public class AffirmationActivity : Activity
{
    private List<string> _affirmations = new List<string>();
    private Random _random = new Random();

    public AffirmationActivity() : base()
    {
        _name = "Affirmation Activity";
        _description = "This activity will help you to increase your self-confidence and foster a positive "
           + "attitude by repeating affirmation statements to yourself."; 
        _duration = 0;
        LoadAffirmStatements();
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.Write("\nGet ready to repeat out loud '3 times' the following statement of affirmation: ");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (endTime > DateTime.Now)
        {
            DisplayAffirmStatements();
        }

        DisplayEndingMessage();
    }

    private void LoadAffirmStatements()
    {
        _affirmations.Add("I am capable of achieving great things!");
        _affirmations.Add("I am grateful for the good things in my life!");
        _affirmations.Add("I believe in myself and my abilities!");
        _affirmations.Add("I am constantly growing and improving!");
        _affirmations.Add("I am deserving of happiness and success!");
        _affirmations.Add("I will embrace challenges as opportunities to grow!");
        _affirmations.Add("I will trust the Lord with all my heart!");
        _affirmations.Add("I am worthy of love and respect!");
        _affirmations.Add("I will radiate kindness and learn to forgive others!");
        _affirmations.Add("I am a Child of God and I know that He loves me!");
    }

    private void DisplayAffirmStatements()
    {
        int numOfAffirmations = _affirmations.Count;
        int affirmationIndex = _random.Next(0, numOfAffirmations);
        string affirmation = _affirmations[affirmationIndex];
        string[] words = affirmation.Split(" ");

        Console.Write("--- ");
        foreach (string word in words)
        {
            Console.Write($"{word} ");
            Thread.Sleep(500);
        }
        Console.Write("---  (3x)");
        Console.WriteLine();
        Console.Write("\nHit enter to continue: ");
        ShowDots(8);
        Console.ReadLine();
        Console.WriteLine();
    }
}