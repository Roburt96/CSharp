using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumArray1 = 0;
            int sumArray2 = 0;
            bool identical = true;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
                    identical = false;
                    break;
                }
                sumArray1 += array[i];
                sumArray2 += array2[i];
            }

            if (identical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumArray1}");
            }
            
            
            
        }
    }
}