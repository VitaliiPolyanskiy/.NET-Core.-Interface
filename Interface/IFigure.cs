using System;

interface IFigure
{
    void FigureType();
    void Area();
    void ColorPrint(ConsoleColor background, ConsoleColor foreground)
    {
        Console.BackgroundColor = background;
        Console.ForegroundColor = foreground;
    }
    double PropA
    {
        get;
        set;
    }
}

interface IFigureAngle: IFigure
{
    const int minAngle = 3;    
    static int maxAngle = 10;   
    void Diagonal();
    double PropB
    {
        get;
        set;
    }
}

interface IFigureRound : IFigure
{
    void Length();
}