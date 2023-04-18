using System;
using System.Linq;

namespace Reverse_array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            Console.WriteLine(String.Join(" ", array.Reverse()));
        }
    }
}