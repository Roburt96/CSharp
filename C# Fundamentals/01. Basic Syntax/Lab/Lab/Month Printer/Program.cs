using System;
using System.Collections.Generic;
namespace Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> months = new Dictionary<int, string>()
            {
                {1, "January"},
                {2, "February"},
                {3, "March"},
                {4, "April"},
                {5, "May"},
                {6, "June"},
                {7, "July"},
                {8, "August"},
                {9, "September"},
                {10, "October"},
                {11, "November"},
                {12, "December"}
            };
            
            var monthNumber = Convert.ToInt32(Console.ReadLine());

            if (months.ContainsKey(monthNumber))
                Console.WriteLine(months[monthNumber]);
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}