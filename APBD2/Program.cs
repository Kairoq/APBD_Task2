var list = new double[2];
for (var i = 0; i <= 1; i++)
{
    list[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine(Addition(list[0], list[1]));
Console.WriteLine(Subtraction(list[0], list[1]));
Console.WriteLine(Average(list[0], list[1]));


static double Addition(double b1, double b2)
    {
        return b1 + b2;
    }

static double Subtraction(double b1, double b2)
{
    return b1 - b2;
}

double Average(double b1, double b2)
{
    return b1 + b2 / list.Length;
}
    