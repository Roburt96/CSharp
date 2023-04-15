using System;
using System.Collections.Generic;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            histogram();
        }

        static void histogram()
        {
            Dictionary<string, int> data = new Dictionary<string, int>()
            {
                {"p1", 0},
                {"p2", 0},
                {"p3", 0},
                {"p4", 0},
                {"p5", 0}
            };
            

            var range = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < range; i++)
            {
                var currentNumber = Convert.ToInt32(Console.ReadLine());
                if (0 <= currentNumber && currentNumber < 200)
                {
                    data["p1"] += 1;
                }
                else if (200 <= currentNumber && currentNumber < 399)
                {
                    data["p2"] += 1;
                }
                
                else if (400 <= currentNumber && currentNumber < 599)
                {
                    data["p3"] += 1;
                }
                
                else if (600 <= currentNumber && currentNumber < 799)
                {
                    data["p4"] += 1;
                }
                
                else if (currentNumber >= 800)
                {
                    data["p5"] += 1;
                }
  
            }
            
            foreach (var item in data)
            {
                
                double percent = ((double)item.Value / range) * 100;
                Console.WriteLine($"{percent:F2}%");
            }
        }
    }
}