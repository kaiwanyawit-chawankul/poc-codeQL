using System;

public class ComplexCalculator
{
    public int Calculate(int a, int b, string operation)
    {
        if (a < 0 || b < 0)
        {
            throw new ArgumentException("Parameters must be non-negative.");
        }

        int result = 0;

        switch (operation)
        {
            case "add":
                result = a + b;
                break;
            case "subtract":
                result = a - b;
                break;
            case "multiply":
                for (int i = 0; i < b; i++)
                {
                    result += a;
                }
                break;
            case "divide":
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                result = a / b;
                break;
            case "power":
                result = Power(a, b);
                break;
            default:
                throw new NotSupportedException("Operation not supported.");
        }

        if (result > 100)
        {
            Console.WriteLine("Result is greater than 100.");
        }
        else if (result < 0)
        {
            Console.WriteLine("Result is negative.");
        }
        else
        {
            Console.WriteLine("Result is within range.");
        }

        return result;
    }

    private int Power(int baseNum, int exponent)
    {
        if (exponent < 0)
        {
            throw new ArgumentException("Exponent must be non-negative.");
        }

        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }
        return result;
    }
}
