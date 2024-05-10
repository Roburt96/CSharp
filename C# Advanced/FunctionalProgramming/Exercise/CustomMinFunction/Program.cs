using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        List<int> numbers = input .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse) 
            .ToList();

        Func<List<int>, int> findSmallest = nums => nums.Min();

        int smallestNumber = findSmallest(numbers);

        Console.WriteLine(smallestNumber);
    }
}
