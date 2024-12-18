using System;

public class Swimming : Activity
{
    private int _numberOfLaps;
    
    public Swimming(string date, int length, int laps) : base(date, length, "Swimming")
    {
        _numberOfLaps = laps;
    }

    protected override double GetDistance()   
    {
        return CalculateDistance(_numberOfLaps); 
    }

    protected override double GetSpeed()
    {
        return CalculateSpeed(GetDistance(), GetLength());
    }
} 