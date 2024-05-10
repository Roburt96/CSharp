using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int CalculateAsciiSum(string name)
    {
        int sum = 0;
        foreach (char c in name)
        {
            sum += (int)c; 
        }
        return sum;
    }
    static bool IsAsciiSumGreaterThanOrEqual(string name, int threshold)
    {
        return CalculateAsciiSum(name) >= threshold; 
    }
    static string FindFirstMatchingName(List<string> names, Func<string, int, bool> condition, int threshold)
    {
        foreach (var name in names)
        {
            if (condition(name, threshold))
            {
                return name; 
            }
        }
        return "No match found";
    }

    static void Main(string[] args)
    {
        int threshold = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine().Split().ToList();
        string result = FindFirstMatchingName(names, IsAsciiSumGreaterThanOrEqual, threshold);

        Console.WriteLine(result);
    }
}
