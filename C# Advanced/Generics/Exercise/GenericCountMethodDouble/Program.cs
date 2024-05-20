using System;
using System.Collections.Generic;
using System.Globalization;

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
    public static int CountGreaterThan<T>(List<Box<T>> list, Box<T> element) where T : IComparable<T>
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
        List<Box<double>> boxes = new List<Box<double>>();

        for (int i = 0; i < n; i++)
        {
            double input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            boxes.Add(new Box<double>(input));
        }

        double comparisonValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Box<double> comparisonBox = new Box<double>(comparisonValue);

        int result = CountGreaterThan(boxes, comparisonBox);
        Console.WriteLine(result);
    }
}
