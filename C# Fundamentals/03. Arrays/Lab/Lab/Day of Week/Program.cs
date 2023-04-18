using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDay = new string[]
                {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput >= 1 && userInput <= 7)
            {
                Console.WriteLine(weekDay[userInput - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            
        }
    }
}