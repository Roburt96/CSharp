using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ');
        string command = Console.ReadLine().ToLower();

        int lower = int.Parse(input[0]);
        int upper = int.Parse(input[1]);
       

        Predicate<int> condition;

        if (command == "even")
        {
            condition = n => n % 2 == 0;
        }
        else if (command == "odd")
        {
            condition = n => n % 2 != 0;
        }
        else
        {
            return;
        }

        List<int> result = new List<int>();

        for (int i = lower; i <= upper; i++)
        {
            if (condition(i))
            {
                result.Add(i);
            }
        }
        foreach (int number in result)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
