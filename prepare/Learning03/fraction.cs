public class Fraction
{
    private int numerator;
    private int denominator;
// constructors
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction (int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
    }

    public Fraction (int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator == 0 ? 1 : denominator;
    }

    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set { denominator = value != 0 ? value : 1;}
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }

    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    public double GetDecimalValue()
    {
        return (double) numerator / denominator;
    }
}