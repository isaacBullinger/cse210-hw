using System;
using System.Globalization;

public class Fraction
{
    
    private int _numerator;
    private int _denominator;

    public Fraction()
    {

        _numerator = 1;
        _denominator = 1;

    }

    public Fraction(int wholeNumber)
    {

        _numerator = wholeNumber;
        _denominator = 1;

    }

    public Fraction(int numerator, int denominator)
    {

        _numerator = numerator;
        _denominator = denominator;

    }

    public string GetFractionString()
    {
        string fraction = $"{_numerator}/{_denominator}";

        return fraction;
    }

    public double GetDecimalValue()
    {

        double fraction = (double)_numerator / (double)_denominator;
        
        return fraction;

    }
}