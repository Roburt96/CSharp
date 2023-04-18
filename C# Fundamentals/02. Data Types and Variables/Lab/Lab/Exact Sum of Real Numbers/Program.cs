using System;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal totalSum = 0;
            for (int i = 0; i < numbers; i++)
            {
                decimal currentNum = Convert.ToDecimal(Console.ReadLine());
                totalSum += currentNum;
            }
            
            Console.WriteLine(totalSum);
        }
    }
}