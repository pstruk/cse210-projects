using System;

class Program
{
    static void Main(string[] args)
    {
        // step 7-part 1;
        List<Shape> shapes = new List<Shape>();

        // step 5-Test for step 4; step 7-part 2;
        Square square1 = new Square("Blue", 3.5);
        shapes.Add(square1);
        // Console.WriteLine($"Square color = {square1.GetColor()}");
        // Console.WriteLine($"Square area = {square1.GetArea()}");

        // step 5-Test for step 6; step 7-part 2;
        Rectangle rectangle1 = new Rectangle("Orange", 2.0, 4.0);
        shapes.Add(rectangle1);
        // Console.WriteLine($"Rectangle color = {rectangle1.GetColor()}");
        // Console.WriteLine($"Rectangle area = {rectangle1.GetArea()}");  

        // step 5-Test for step 6; step 7-part 2;
        Circle circle1 = new Circle("Yellow", 2.5);
        shapes.Add(circle1);
        // Console.WriteLine($"Circle color = {circle1.GetColor()}"); 
        // Console.WriteLine($"Circle area = {circle1.GetArea()}");

        // step 7, part 3 - iterate through list
        foreach (Shape item in shapes)
        {
          string color = item.GetColor();
          double area = item.GetArea();
          
          Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }

}

