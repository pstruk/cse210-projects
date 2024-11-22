using System;

public class Fraction 
{
    private int _top;
    private int _bottom;

    // Step 4.1: Create the Constructors:
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // STEP 5: Create the Getters and Setters:
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    
    // STEP 6: Create Methods
    public string GetFractionString()
    {
        // Create a temporary local variable to hold the value and return the variable:
        // Optionally, this also works: return _top + "/" + _bottom;
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Note: This is not stored as a member variable and will be recomputed each time it's called.
        // A double will be returned as long as (double) touches either the Numerator or Denominator 
        // i.e. return _top / (double)_bottom;  will return a double.

        return (double)_top / (double)_bottom;
    }
    
    

    
}
