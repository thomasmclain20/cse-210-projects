using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("red", 5);
        s1.GetColor();
        s1.GetArea();
        Console.WriteLine(s1.GetColor());
        Console.WriteLine(s1.GetArea());

        List<Shape> L1 = new List<Shape>();
        L1.Add(new Square("red", 5));
        L1.Add(new Circle("blue", 3));
        L1.Add(new Rectangle("green", 4, 6));
        L1.Add(new Circle("yellow", 2));

        foreach (Shape shape in L1)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }

        
    }
}