// Клонирование объектов. Реализация глубокого копирования 

using System;

class Club : ICloneable
{
    public string Name { get; set; }
    public string City { get; set; }
    public Coach Coach { get; set; }

    public Club(string name, string city, string coach)
    {
        Name = name;
        City = city;
        Coach = new Coach();
        Coach.Name = coach;
    }
    public Club() : this("Динамо", "Киев", "Александр Шовковский") { }
    public override string ToString()
    {
        return string.Format("\n{0}, {1}, {2}", Name, City, Coach.Name);
    }
    public object Clone()
    {
        return new Club(Name, City, Coach.Name);
    }

    //public object Clone()
    //{
    //    return this.MemberwiseClone(); // Поверхностное копирование
    //}
}

class Coach
{
    public string Name { get; set; }
}

class MainClass
{
    public static void Main()
    {
        Club c = new Club();
        Console.WriteLine(c);
        Club c2 = c; // обе ссылки указывают на один и тот же объект
        c2.Name = "Шахтер";
        c2.City = "Донецк";
        c2.Coach.Name = "Марино Пушич";
        Console.WriteLine(c.ToString());
        Func(c);
        Console.WriteLine(c.ToString());
    }
    static void Func(ICloneable cloneable)
    {
        object o = cloneable.Clone(); // две независимые копии
        Console.WriteLine(o.ToString());
        Club c = o as Club; 
        c.Name = "Черноморец";
        c.City = "Одесса";
        c.Coach.Name = "Александр Бабич";
        Console.WriteLine(o.ToString());
    }
}
