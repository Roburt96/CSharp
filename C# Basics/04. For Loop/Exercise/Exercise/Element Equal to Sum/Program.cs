using System;

namespace Element_Equal_to_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            equalSum();
        }

        static void equalSum()
        {
            int sum = 0;
            int max = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                    if (num > max) max = num;
            }

            int sumWithoutMaxNumber = sum - max;
            if (max == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }        
    }
} 