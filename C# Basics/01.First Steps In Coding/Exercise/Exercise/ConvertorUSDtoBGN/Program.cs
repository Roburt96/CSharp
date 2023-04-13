using System;

namespace ConvertorUSDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 1.79549;
            int bgn = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine(bgn * usd);
        }
    }
}