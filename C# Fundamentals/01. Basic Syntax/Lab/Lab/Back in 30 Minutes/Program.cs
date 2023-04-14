using System;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            int afterMinutes = 30;
            int totalMinutes = afterMinutes + minutes;
            if (totalMinutes > 59) 
            {
                hours++;
                if (hours == 24)
                {
                    hours = 0;
                    totalMinutes -= 60;
                    Console.WriteLine($"{hours}:{totalMinutes:d2}");
                }
                else
                {
                    totalMinutes -= 60;
                    Console.WriteLine($"{hours}:{totalMinutes:d2}");
                }
            }
            else
            {
                Console.WriteLine($"{hours}:{totalMinutes:d2}");
            }
        }
    }
}