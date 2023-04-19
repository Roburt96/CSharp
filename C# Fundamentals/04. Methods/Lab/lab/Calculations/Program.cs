using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var numA = int.Parse(Console.ReadLine());
            var numB = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(numA, numB);
                    break;
                
                case "subtract":
                    Subtract(numA, numB);
                    break;
                
                case "multiply":
                    Multiply(numA, numB);
                    break;
                
                case "divide":
                    Divide(numA, numB);
                    break;
            }
        }

        private static void Add(int numA, int numB)
        {
            var result = numA + numB;
            Console.WriteLine(result);
        }

        private static void Subtract(int numA, int numB)
        {
            var result = numA - numB;
            Console.WriteLine(result);
        }

        private static void Multiply(int numA, int numB)
        {
            var result = numA * numB;
            Console.WriteLine(result);
        }

        private static void Divide(int numA, int numB)
        {
            var result = numA / numB;
            Console.WriteLine(result);
        }
    }
}