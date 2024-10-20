using System;
class Rectangle : IFigureAngle
{
    protected double width, height;
    public Rectangle(double n1, double n2)
    {
        width = n1;
        height = n2;
    }
    public double PropA
    {
        get
        {
            return width;
        }
        set
        {
            if (width > 0)
                width = value;
        }
    }

    public double PropB
    {
        get
        {
            return height;
        }
        set
        {
            if (height > 0)
                height = value;
        }
    }

    public void FigureType()
    {
        Console.WriteLine("\nПрямоугольник");
    }

    public void Area()
    {
        Console.WriteLine("Площадь прямоугольника равна: {0:F2}", width * height);
    }

    public void Diagonal()
    {
        Console.WriteLine("Длина диагонали равна: {0:F2}", Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2)));
    }

    public void Perimetr()
    {
        Console.WriteLine("Периметр прямоугольника равна: {0:F2}", 2*(width + height));
    }
}