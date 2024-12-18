using System;

public class Running : Activity
{
    private double _distance;
           
    public Running(string date, int length, double distance) : base(date, length, "Running")
    {
        _distance = distance;
    }

    protected override double GetSpeed()
    {
        return CalculateSpeed(_distance, GetLength());
    }

    protected override double GetDistance()
    {
        return _distance;
    }
}