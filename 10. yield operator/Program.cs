using System;
using System.Collections;


public class List
{
    public static IEnumerable Power(int number, int exponent)
    {
        Console.WriteLine("\nВыполняется метод GetEnumerator");
        int counter = 0;
        int result = 1;
        while (true)
        {
            result = result * number;
            yield return result;
            if (++counter == exponent)
                yield break;
        }
    }

    static void Main()
    {
        // Display powers of 2 up to the exponent 8:
        foreach (int i in Power(2, 8))
        {
            Console.Write("{0} ", i);
        }
    }
}