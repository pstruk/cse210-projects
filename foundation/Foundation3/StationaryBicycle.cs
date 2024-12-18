using System;

public class StationaryBicycle : Activity
{
    private int _speed;
    
    public StationaryBicycle(string date, int length, int speed) : base(date, length, "Stationary Bicycle")
    {
        _speed = speed;
    }
        
    protected override double GetSpeed()
    {
        return _speed;
    }

    protected override double GetDistance()
    {
        return _speed * GetLength() / 60.0;
    }
} 