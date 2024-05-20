using System;
using System.Collections.Generic;

public class Box<T> : IComparable<Box<T>> where T : IComparable<T>
{
    private T value;

    public Box(T value)
    {
        this.value = value;
    }

    public int CompareTo(Box<T> other)
    {
        if (other == null) return 1;
        return this.value.CompareTo(other.value);
    }

    public override string ToString()
    {
        return $"{typeof(T)}: {value}";
    }

    public T GetValue()
    {
        return this.value;
    }
}

class Program
{
    public static int CountGreaterThan<T>(List<T> list, T element) where T : IComparable<T>
    {
        int count = 0;
        foreach (var item in list)
        {
            if (item.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> boxes = new List<Box<string>>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            boxes.Add(new Box<string>(input));
        }

        string comparisonValue = Console.ReadLine();
        Box<string> comparisonBox = new Box<string>(comparisonValue);

        int result = CountGreaterThan(boxes, comparisonBox);
        Console.WriteLine(result);
    }
}
