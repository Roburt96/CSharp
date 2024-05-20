using System;
using System.Globalization;

public class Threeuple<T1, T2, T3>
{
    private T1 item1;
    private T2 item2;
    private T3 item3;

    public Threeuple(T1 item1, T2 item2, T3 item3)
    {
        this.item1 = item1;
        this.item2 = item2;
        this.item3 = item3;
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

    public T3 Item3
    {
        get { return item3; }
        set { item3 = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] nameAddressTown = Console.ReadLine().Split();
        string fullName = $"{nameAddressTown[0]} {nameAddressTown[1]}";
        string address = nameAddressTown[2];
        string town = nameAddressTown[3];

        Threeuple<string, string, string> nameAddressTownTuple = new Threeuple<string, string, string>(fullName, address, town);
        Console.WriteLine($"{nameAddressTownTuple.Item1} -> {nameAddressTownTuple.Item2} -> {nameAddressTownTuple.Item3}");

        string[] nameBeerDrunk = Console.ReadLine().Split();
        string name = nameBeerDrunk[0];
        int beerLiters = int.Parse(nameBeerDrunk[1]);
        bool isDrunk = nameBeerDrunk[2] == "drunk";

        Threeuple<string, int, bool> nameBeerDrunkTuple = new Threeuple<string, int, bool>(name, beerLiters, isDrunk);
        Console.WriteLine($"{nameBeerDrunkTuple.Item1} -> {nameBeerDrunkTuple.Item2} -> {nameBeerDrunkTuple.Item3}");

        string[] nameBalanceBank = Console.ReadLine().Split();
        name = nameBalanceBank[0];
        double accountBalance = double.Parse(nameBalanceBank[1], CultureInfo.InvariantCulture);
        string bankName = nameBalanceBank[2];

        Threeuple<string, double, string> nameBalanceBankTuple = new Threeuple<string, double, string>(name, accountBalance, bankName);
        Console.WriteLine($"{nameBalanceBankTuple.Item1} -> {nameBalanceBankTuple.Item2.ToString(CultureInfo.InvariantCulture)} -> {nameBalanceBankTuple.Item3}");
    }
}
