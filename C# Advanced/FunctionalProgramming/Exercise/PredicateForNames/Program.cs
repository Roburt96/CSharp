using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine().Split(' ').ToList();
        List<string> filteredNames = names.Where(name => name.Length <= n).ToList();


        foreach(var name in filteredNames)
        {
            Console.WriteLine(name);
        }
    }
}
