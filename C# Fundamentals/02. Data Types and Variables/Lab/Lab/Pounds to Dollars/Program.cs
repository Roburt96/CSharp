using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pound = 1.31;
            
            var dollars = Convert.ToInt32(Console.ReadLine());
            var converted = dollars * pound;
            Console.WriteLine($"{converted:f3}");
        }
    }
}