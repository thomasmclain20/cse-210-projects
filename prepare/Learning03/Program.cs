using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1= new Fraction();
        Fraction f2 = new Fraction(3, 4);
        Fraction f3 = new Fraction(5);
        Console.WriteLine(f1.ToString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f2.Numerator);
        f2.Numerator = 7;
        Console.WriteLine(f2.ToString());
    }
}