using System;
using System.Collections.Generic;

public class Box<T>
{
    private T value;

    public Box(T value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return $"{typeof(T)}: {value}";
    }
}

class Program
{
    public static void SwapElements<T>(List<T> list, int index1, int index2)
    {
        T temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
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

        string[] indexes = Console.ReadLine().Split();
        int index1 = int.Parse(indexes[0]);
        int index2 = int.Parse(indexes[1]);

        SwapElements(boxes, index1, index2);

        foreach (var box in boxes)
        {
            Console.WriteLine(box.ToString());
        }
    }
}
