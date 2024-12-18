using System;

public abstract class Activity
{
    private string _date;
    private int _length;
    private string _activity;

    public Activity(string date, int length, string activity)
    {
        _date = date;
        _length = length;
        _activity = activity;
    }

    protected virtual double GetSpeed()   
    {
        return CalculateSpeed(CalculatePace(GetDistance(), _length));
    }

    protected virtual double GetPace()   
    {
        return CalculatePace(GetSpeed());
    }

    protected abstract double GetDistance();
    
    
    private string GetDate()
    {
        return _date;
    }

    private string GetActivityName()
    {
        return _activity;
    }

    protected int GetLength()
    {
        return _length;
    }

    protected double CalculateDistance(int laps)
    {
        return laps * 50.0/1000.0 * 0.62;
    }

    protected double CalculateSpeed(double distance, int length)
    {
        return (distance / length) * 60.0;
    }

    protected double CalculateSpeed(double pace)
    {
        return 60.0 / pace;
    }

    protected double CalculatePace(double distance, int length)
    {
        return length / distance;
    }

    protected double CalculatePace(double speed)
    {
        return 60.0 / speed;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{GetDate()} {GetActivityName()}({GetLength()} min): "
           + $"Distance {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, "
           + $"Pace: {GetPace():F1} min per mile");
    }
} 