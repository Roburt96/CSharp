using System;

namespace Read_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            while (command != "Stop")
            {
                Console.WriteLine(command);
                command = Console.ReadLine();
            }
                
        }
    }
}