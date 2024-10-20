using System;

interface IBase
{
    void F();
}

class Base : IBase
{
    public void F()
    {
        Console.WriteLine("It's base!");
    }
}

class Derived : Base
{
    public new void F()
    {
        Console.WriteLine("It's derived!");
    }
}

class Demo
{
    public static void Main()
    {
        Derived d = new Derived();
        d.F(); // F - из класса Derived
        IBase obj = d;
        obj.F(); // F - из класса Base
    }
}
