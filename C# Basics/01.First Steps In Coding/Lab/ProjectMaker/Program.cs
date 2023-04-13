using System;

namespace ProjectMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneProject = 3;

            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int totalTime = oneProject * projects;
            
            Console.WriteLine($"The architect {name} will need {totalTime} hours to complete" +
                              $" {projects} project/s.");
        }
    }
}