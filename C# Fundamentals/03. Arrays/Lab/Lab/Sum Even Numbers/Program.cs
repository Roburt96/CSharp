using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
            }
            
            Console.WriteLine(sum);
            
            
        }
    }
}