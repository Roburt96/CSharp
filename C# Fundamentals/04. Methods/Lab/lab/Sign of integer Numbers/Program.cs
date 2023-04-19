using System;

namespace Sign_of_integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            checKNumber(n);
        }

        static void checKNumber(int num)
        {
            if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}