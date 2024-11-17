using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    HashSet<int> _duplicates = new HashSet<int>();

    Random randomGenerator = new Random();

    public PromptGenerator()
    {
        _prompts.Add("Write about one of your childhood memories.");
        _prompts.Add("List three things you're grateful for.");
        _prompts.Add("Who was the most interesting person you interacted with today?");
        _prompts.Add("What is something new that you learned about today?");
        _prompts.Add("If there was one thing you could do over today, what would it be?");
        _prompts.Add("How did you see the hand of the Lord working in your life today?");
        _prompts.Add("Write about a goal that you would like to achieve this month.");
        _prompts.Add("At this moment in time, what's a word that you would use to describe yourself and why?");
    }

    public int GetRandomNumber()
    {
        int number = randomGenerator.Next(0, _prompts.Count);
        return number;
    } 

    public string GetRandomPrompt()
    {
        bool found = false;
        int randomNumber = -1;
        while (AnyPromptsRemaining() && !found)
        {
            randomNumber = GetRandomNumber();
            if (!Duplicate(randomNumber))
            {
                found = true;
                _duplicates.Add(randomNumber);
            } 
        } 
        if (randomNumber < 0)
        {
            return "No Prompts";
        }
        string randomPrompt = _prompts[randomNumber];
        return randomPrompt;
    }

    public bool Duplicate(int number)
    {
        return _duplicates.Contains(number);
    }

    public bool AnyPromptsRemaining()
    {
        return !(_duplicates.Count == _prompts.Count);
       
    } 

}