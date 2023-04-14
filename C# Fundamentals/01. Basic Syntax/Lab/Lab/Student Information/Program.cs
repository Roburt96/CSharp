using System;

namespace Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());
            double grade = Double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade.ToString("N2")}");
        }
    }
}