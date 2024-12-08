using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing "
          + "in and out slowly. \nCLEAR your mind and focus on your breathing.";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("Prepare to begin deep breathing...");
        ShowSpinner(3);
        
        int activityLength = _duration;

        while (activityLength > 0)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(4);
            Console.WriteLine();
            activityLength -= 8;
        }
        
       DisplayEndingMessage(); 
    }
}