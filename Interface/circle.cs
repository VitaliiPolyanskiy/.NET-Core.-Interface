using System;
class Circle : IFigureRound
{
    public void ColorPrint(ConsoleColor background, ConsoleColor foreground)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Magenta;
    }

    protected double radius;
    public Circle(double n1)
    {
        radius = n1;
    }
    public double PropA
    {
        get
        {
            return radius;
        }
        set
        {
            if (radius > 0)
                radius = value;
        }
    }
    public void FigureType()
    {
        Console.WriteLine("\nОкружность");
    }
    public void Area()
    {
        Console.WriteLine("Площадь окружности равна: {0:F2}", Math.PI * Math.Pow(radius, 2));
    }

    public void Length()
    {
        Console.WriteLine("Длина окружности равна: {0:F2}", 2 * Math.PI * radius);
    }

}