// Использование явной реализации для того, чтобы избежать неоднозначности

using System;

interface IMyIF_A
{
    int Meth(int x);
}

interface IMyIF_B
{
    int Meth(int x);  
}

class A : IMyIF_A, IMyIF_B
{
    // Одна общая реализация для обоих интерфейсов
    public int Meth(int x)
    {
        return x + x;
    }
}

// В классе MyClass реализованы оба интерфейса
class B : IMyIF_A, IMyIF_B
{
    // Явным образом реализуем два метода meth()
    int IMyIF_A.Meth(int x)
    {
        return x + x;
    }
    int IMyIF_B.Meth(int x)
    {
        return x * x;
    }
    // Вызываем метод meth() посредством ссылки на интерфейс
    public int MethA(int x)
    {
        IMyIF_A a_ob;
        a_ob = this;
        return a_ob.Meth(x); // Имеется в виду интерфейс IMyIF_A
    }
    public int MethB(int x)
    {
        IMyIF_B b_ob;
        b_ob = this;
        return b_ob.Meth(x); // Имеется в виду интерфейс IMyIF_B
    }
}

class MainClass
{
    public static void Main()
    {
        A obj1 = new A();
        Console.Write("Вызов метода A.meth(): ");
        Console.WriteLine(obj1.Meth(7));
        IMyIF_A ia = obj1;
        Console.Write("Вызов метода IMyIF_A.meth(): ");
        Console.WriteLine(ia.Meth(7));
        IMyIF_B ib = obj1;
        Console.Write("Вызов метода IMyIF_B.meth(): ");
        Console.WriteLine(ib.Meth(7));

        B obj2 = new B();
        Console.Write("Вызов метода IMyIF_A.meth(): ");
        Console.WriteLine(obj2.MethA(3));
        Console.Write("Вызов метода IMyIF_B.meth(): ");
        Console.WriteLine(obj2.MethB(3));

        IMyIF_A a = obj2;
        Console.Write("Вызов метода IMyIF_A.meth(): ");
        Console.WriteLine(a.Meth(4));
        Console.Write("Вызов метода IMyIF_B.meth(): ");
        Console.WriteLine((obj2 as IMyIF_B).Meth(4));
    }
}