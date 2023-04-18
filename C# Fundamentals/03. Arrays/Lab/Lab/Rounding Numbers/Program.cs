using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " => " + Math.Round((Convert.ToDecimal(array[i])), MidpointRounding.AwayFromZero));
            }
        }
    }
}