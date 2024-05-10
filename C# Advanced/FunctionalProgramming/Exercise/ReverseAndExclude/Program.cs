using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());
        numbers.Reverse();

        numbers = numbers.Where(num => num % n != 0).ToList();
        Console.WriteLine(string.Join(" ", numbers));
    }
}
