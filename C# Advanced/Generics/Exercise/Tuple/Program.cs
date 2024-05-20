using System;
using System.Globalization;

public class Tuple<T1, T2>
{
    private T1 item1;
    private T2 item2;

    public Tuple(T1 item1, T2 item2)
    {
        this.item1 = item1;
        this.item2 = item2;
    }

    public T1 Item1
    {
        get { return item1; }
        set { item1 = value; }
    }

    public T2 Item2
    {
        get { return item2; }
        set { item2 = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] nameAndAddress = Console.ReadLine().Split();
        string firstName = nameAndAddress[0];
        string lastName = nameAndAddress[1];
        string address = nameAndAddress[2];

        Tuple<string, string> nameAndAddressTuple = new Tuple<string, string>(firstName + " " + lastName, address);
        Console.WriteLine($"{nameAndAddressTuple.Item1} -> {nameAndAddressTuple.Item2}");

        string[] nameAndBeer = Console.ReadLine().Split();
        string personName = nameAndBeer[0];
        int litersOfBeer = int.Parse(nameAndBeer[1]);


        Tuple<string, int> nameAndBeerTuple = new Tuple<string, int>(personName, litersOfBeer);
        Console.WriteLine($"{nameAndBeerTuple.Item1} -> {nameAndBeerTuple.Item2}");

        string[] integerAndDouble = Console.ReadLine().Split();
        int integer = int.Parse(integerAndDouble[0]);
        double doubleValue = double.Parse(integerAndDouble[1], CultureInfo.InvariantCulture);

        Tuple<int, double> integerAndDoubleTuple = new Tuple<int, double>(integer, doubleValue);
        Console.WriteLine($"{integerAndDoubleTuple.Item1} -> {integerAndDoubleTuple.Item2.ToString(CultureInfo.InvariantCulture)}");

    }
}
