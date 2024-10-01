using System;

public class Example
{
    public void ComplexMethod(int a, int b, int c)
    {
        if (a > 0)
        {
            if (b > 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("All are positive");
                }
                else
                {
                    Console.WriteLine("a and b are positive, c is not");
                }
            }
            else
            {
                if (c > 0)
                {
                    Console.WriteLine("a and c are positive, b is not");
                }
                else
                {
                    Console.WriteLine("Only a is positive");
                }
            }
        }
        else
        {
            if (b > 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("b and c are positive, a is not");
                }
                else
                {
                    Console.WriteLine("Only b is positive");
                }
            }
            else
            {
                if (c > 0)
                {
                    Console.WriteLine("Only c is positive");
                }
                else
                {
                    Console.WriteLine("None are positive");
                }
            }
        }
    }
}
