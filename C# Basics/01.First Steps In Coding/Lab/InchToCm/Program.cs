using System;

namespace InchToCm
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = 2.54;
            int a = int.Parse(Console.ReadLine());

            double result = a * inch;
            Console.WriteLine(result);

        }
    }
}