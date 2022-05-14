﻿namespace WebCalculator;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
    
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    
    public int Divide(int a, int b)
    {
        if( b != 0 )
            return a / b;
        return int.MaxValue;
    }
}