﻿using System;

namespace HelloByName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            
            // Console.WriteLine($"Hello, {name}!");
        }
    }
}