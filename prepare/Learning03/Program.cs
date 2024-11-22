using System;

class Program
{
    static void Main(string[] args)
    {
        // STEP 4.2: Creating Constructors:
        // Fraction f1 = new Fraction();
        // Console.WriteLine(f1.GetFractionString());   // results in 1/1
        
        // Fraction f2 = new Fraction(6);
        // Console.WriteLine(f2.GetFractionString());   // results in 6/1
        
        // Fraction f3 = new Fraction(6, 7);
        // Console.WriteLine(f3.GetFractionString());   // results in 6/7
        

        // STEP 6.3: Create methods to return representations:
        // Matches the supplied Sample Output
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());   // results in 1/1
        Console.WriteLine(f1.GetDecimalValue());     // results in 1
        
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());   // results in 5/1
        Console.WriteLine(f2.GetDecimalValue());     // results in 5
        
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());   // results in 3/4
        Console.WriteLine(f3.GetDecimalValue());     // results in .75
        
        Fraction f4 = new Fraction(1, 3);  
        Console.WriteLine(f4.GetFractionString());   // results in 1/3
        Console.WriteLine(f4.GetDecimalValue());     // results in 0.3333333333333333

    }
}