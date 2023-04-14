using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var targetSum = int.Parse(Console.ReadLine());


            while (targetSum > sum)
            {
                var numbers = int.Parse(Console.ReadLine());
                sum += numbers;
            }
            Console.WriteLine(sum);
        }
    }
}