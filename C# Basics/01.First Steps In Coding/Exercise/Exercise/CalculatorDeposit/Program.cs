using System;

namespace CalculatorDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            int depositSum = int.Parse(Console.ReadLine());
            int depositTime = int.Parse(Console.ReadLine());
            double depositYearPercent = double.Parse(Console.ReadLine()) / 100;

            double totalInterest = depositSum * depositYearPercent;
            double InterestPerMonth = totalInterest / 12;
            double totalSum = depositSum + depositTime * InterestPerMonth;
            
            Console.WriteLine(totalSum);
        }
    }
}