using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var list = new double[2];

        for (var i = 0; i < list.Length; i++)
        {
            list[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine(Addition(list[0], list[1]));
        Console.WriteLine(Subtraction(list[0], list[1]));
        Console.WriteLine(Average(list[0], list[1]));
        Console.WriteLine(FindMax(list[0], list[1]));
        Console.WriteLine(FindMin(list));
    }

    static double Addition(double b1, double b2)
    {
        return b1 + b2;
    }

    static double Subtraction(double b1, double b2)
    {
        return b1 - b2;
    }

    static double Average(double b1, double b2)
    {
        return (b1 + b2) / 2;
    }

    static double FindMax(double b1, double b2)
    {
        return b1 > b2 ? b1 : b2;
    }

    static double FindMin(double[] values)
    {
        return values.Min();
    }
    
    static double Multiply(double b1, double b2)
    {
        return b1 * b2;
    }
}