using System;

class MainClass
{
    private static readonly Random rnd = new();
    public static IFigure GeneratorOfFigures()
    {
        int n = rnd.Next(2);
        switch (n)
        {
            case 0: return new Rectangle(10.5, 6.5);
            case 1: return new Circle(10);
            default: return null;
        }
    }
    static void Main()
    {
        ConsoleColor background, foreground;
        background = Console.BackgroundColor;
        foreground = Console.ForegroundColor;

        Rectangle rect = new Rectangle(8, 10);
        //rect.ColorPrint(ConsoleColor.Red, ConsoleColor.Cyan); // Такого метода в классе нет
        rect.FigureType();
        rect.Area();
        rect.Diagonal();
        rect.PropA = 6;
        rect.PropB = 7;
        rect.Area();
        rect.Diagonal();
        rect.Perimetr();

        Circle crl = new Circle(12);
        crl.ColorPrint(ConsoleColor.Red, ConsoleColor.Cyan);
        crl.FigureType();
        crl.Area();
        crl.Length();
        crl.PropA = 6;
        crl.Area();
        crl.Length();

        IFigureAngle obj = rect;
        obj.ColorPrint(ConsoleColor.Blue, ConsoleColor.Yellow);
        Console.WriteLine("\nМинимальное количество углов: " + IFigureAngle.minAngle);
        Console.WriteLine("\nМаксимальное количество углов: " + IFigureAngle.maxAngle);
        
        obj.FigureType();
        obj.Area();
        obj.Diagonal();
        obj.PropA = 3;
        obj.PropB = 4;
        obj.Area();
        obj.Diagonal();
        (obj as Rectangle).Perimetr(); // Такого метода в интерфейсе нет

        IFigureRound obj2 = crl;
        obj2.FigureType();
        obj2.Area();
        obj2.Length();
        obj2.PropA = 3;
       
        obj2.Area();
        obj2.Length();

        Console.BackgroundColor = background;
        Console.ForegroundColor = foreground;

        IFigure[] p = new IFigure[10];
        int count_rectangle = 0, count_circle = 0;
        for (int i = 0; i < 10; i++)
        {
            p[i] = GeneratorOfFigures();
            if (p[i] is IFigureAngle)
                count_rectangle++;
            if (p[i] is IFigureRound)
                count_circle++;
            p[i].FigureType();
        }
        Console.WriteLine("\nКоличество прямоугольников: " + count_rectangle);
        Console.WriteLine("Количество окружностей: " + count_circle);
        count_rectangle = 0;
        count_circle = 0;

        for (int i = 0; i < 10; i++)
        {
            p[i] = GeneratorOfFigures();
            if (p[i] as IFigureAngle != null)
                count_rectangle++;
            if (p[i] as IFigureRound != null)
                count_circle++;
            p[i].FigureType();
        }
        Console.WriteLine("\nКоличество прямоугольников: " + count_rectangle);
        Console.WriteLine("Количество окружностей: " + count_circle);
    }
}