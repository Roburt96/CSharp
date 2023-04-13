using System;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerMeter = 7.61;
            double discount = 0.18;
            
            int yardMeters = Int32.Parse(Console.ReadLine());
            double sumWithoutDiscount = yardMeters * pricePerMeter;
            double discountSum = sumWithoutDiscount * discount;
            
            Console.WriteLine($"The final price is: {sumWithoutDiscount - discountSum} lv.\n" +
                              $"The discount is: {discountSum} lv.");
        }
    }
}