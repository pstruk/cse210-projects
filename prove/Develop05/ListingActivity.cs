using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private Random _random = new Random();
    
    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by "
            + "having you list as many things as you can in a certain area.";
        _duration = 0;
        
        _prompts.Add("Who are the people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();   
        
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.Write("You may begin in: ");
        ShowCountDown(6);
        Console.WriteLine();
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!");
            
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int promptCount = _prompts.Count;
        int promptIndex = _random.Next(0, promptCount);
        return _prompts[promptIndex];  
    }

    private List<string> GetListFromUser()   
    {
        List<string> userResponses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (endTime > DateTime.Now)        
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            userResponses.Add(response);
        }
        return userResponses;
    }
}    