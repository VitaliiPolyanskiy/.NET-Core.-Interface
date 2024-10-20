// Интерфейсы IEnumerable, IEnumerator
// Эти два интерфейса используются  для того, чтобы можно было применять цикл foreach по отношению к объекту класса

using System;
using System.Collections;
class Club
{
    public string Name { get; set; }

    public string City { get; set; }

    public Club(string name, string city)
    {
        Name = name;
        City = city;
    }

    public Club() : this("Динамо", "Киев") { }

    public void Show()
    {
        Console.WriteLine("\n{0}   {1}", Name, City);
    }

    public void Input()
    {
        Console.WriteLine("\nВведите название клуба: ");
        Name = Console.ReadLine();
        Console.WriteLine("\nВведите название города: ");
        City = Console.ReadLine();
    }
}

// IEnumerable предоставляет перечислитель, который поддерживает простой перебор элементов необобщенной коллекции
// IEnumerator поддерживает простой перебор по необобщенной коллекции
class League : IEnumerable, IEnumerator
{
    Club[] ar;
    int curpos = -1;
    public League(int len)
    {
        ar = new Club[len];
        for (int i = 0; i < len; i++)
        {
            ar[i] = new Club();
        }
    }

    public League() : this(1) { }

    public League(Club[] clubs)
    {
        ar = new Club[clubs.Length];
        for (int i = 0; i < clubs.Length; i++)
        {
            ar[i] = new Club(clubs[i].Name, clubs[i].City);
        }
    }

    public void InputClub()
    {
        for (int i = 0; i < ar.Length; i++)
            ar[i].Input();
    }

    public void ShowClubs()
    {
        for (int i = 0; i < ar.Length; i++)
            ar[i].Show();
    }


    public IEnumerator GetEnumerator()
    {
        Console.WriteLine("\nВыполняется метод GetEnumerator");
        // возвращается ссылка на объект класса, реализующего перечислитель
        return this;
    }

    // реализация перечислителя
    #region enumerator

    //Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции
    public void Reset()
    {
        Console.WriteLine("\nВыполняется метод Reset");
        curpos = -1;
    }
    public object Current // Получает текущий элемент в коллекции
    {
        get
        {
            Console.WriteLine("\nВыполняется свойство Current");
            return ar[curpos];
        }
    }

    // Перемещает перечислитель к следующему элементу коллекции
    public bool MoveNext()
    {
        Console.WriteLine("\nВыполняется метод MoveNext");
        if (curpos < ar.Length - 1)
        {
            curpos++;
            return true;
        }
        else
        {
            Reset();
            return false;
        }

    }
    #endregion enumerator
}

class MainClass
{
    public static void Main()
    {
        Club[] c =
        [
            new Club("Динамо", "Киев"),
            new Club("Бавария", "Мюнхен"),
            new Club("Интер", "Милан"),
            new Club("Реал", "Мадрид"),
            new Club("Челси", "Лондон"),
            new Club("Арсенал", "Лондон"),
        ];
        foreach (Club temp in c)
            temp.Show();
        League lg = new(c);
        foreach (Club temp in lg)
            temp.Show();
        foreach (Club temp in lg)
            temp.Show();
    }
}

