using System;

namespace Convert_M_to_Km
{
    class Program
    {
        static void Main(string[] args)
        {
            var meter = Convert.ToInt32(Console.ReadLine());
            var convertor = meter / 1000m;
            Console.WriteLine($"{convertor:F2}");
        }

        
    }
}