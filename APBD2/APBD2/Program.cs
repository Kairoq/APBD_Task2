double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(a);
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(b);

        Console.WriteLine(Addition(a, b));
        Console.WriteLine(Subtraction(a, b));


static double Addition(double b1, double b2)
    {
        return b1 + b2;
    }

    static double Subtraction(double b1, double b2)
    {
        return b1 - b2;
    }