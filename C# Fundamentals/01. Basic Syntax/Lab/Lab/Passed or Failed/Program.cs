using System;

namespace Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade < 3)
                Console.WriteLine("Failed!");
            else
            {
                Console.WriteLine("Passed!");
            }
            
        }   
        
    }
}