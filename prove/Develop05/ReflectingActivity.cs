using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private Random _random = new Random();
    
    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have " +
            "shown strength and resilience. This will help you recognize the power you have and how " +
            "you can use it in other aspects of your life.";
        LoadPrompts();
        LoadQuestions();
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.Write("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write($"You may begin in: \n");
        ShowCountDown(5);
        Console.WriteLine();
        
        int numQuestions = MinNumberOfQuestions();
        
        while (numQuestions > 0)
        {
            DisplayQuestions();
            numQuestions -= 1;
            
            int spinDuration = _duration / MinNumberOfQuestions();   
            int spinTime = 4;

            while (spinDuration > 0) 
            {
                ShowSpinner(spinTime);
                spinDuration -= spinTime;
            }
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    private int MinNumberOfQuestions()
    {
        int numQuestions; 

        if (_duration % 15 == 0)
        {
            numQuestions = _duration / 15;
        }
        else
        {
            numQuestions = (_duration / 15) + 1;
        }
        return numQuestions;
    }

    private string GetRandomPrompt()   
    {
        int promptCount = _prompts.Count;  
        int promptIndex = _random.Next(0, promptCount); 
        return _prompts[promptIndex]; 
    }

    private string GetRandomQuestion()  
    {
        int questionCount = _questions.Count;
        int questionIndex = _random.Next(0, questionCount);
        return _questions[questionIndex];        
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    private void DisplayQuestions()    
    {
        Console.Write($">   {GetRandomQuestion()}");
    }

    private void LoadPrompts()
    {
        _prompts.Add("Think of a time when you had to make a difficult decision.");
        _prompts.Add("Think of a time when you defended your beliefs.");
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }

    private void LoadQuestions()
    {
        _questions.Add("Was there a better way that you could have handled the situation? ");
        _questions.Add("Why was this experience meaningful to you? ");
        _questions.Add("Have you ever done anything like this before? ");
        _questions.Add("How did you get started? ");
        _questions.Add("How did you feel when it was completed? ");
        _questions.Add("What made this time different than other times when you were not as successful? ");
        _questions.Add("What is your favorite thing about this experience? ");
        _questions.Add("What could you learn from this experience that applies to other situations? ");
        _questions.Add("What did you learn about yourself through this experience? ");
        _questions.Add("How can you keep this experience in mind in the future? ");
    }
}
