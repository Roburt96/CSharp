using System;
using System.Linq;

namespace Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                numbers[i] = num;
            }

            Console.WriteLine(String.Join(" ", numbers.Reverse()));
        }
    }
}