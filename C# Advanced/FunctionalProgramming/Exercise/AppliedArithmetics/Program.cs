﻿using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Add(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] += 1;
        }
    }

    static void Multiply(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] *= 2;
        }
    }

    static void Subtract(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] -= 1;
        }
    }

    static void Print(List<int> numbers)
    {
        Console.WriteLine(string.Join(" ", numbers));
    }

    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string command;

        while ((command = Console.ReadLine()) != "end")
        {
            switch (command)
            {
                case "add":
                    Add(numbers);
                    break;
                case "multiply":
                    Multiply(numbers);
                    break;
                case "subtract":
                    Subtract(numbers);
                    break;
                case "print":
                    Print(numbers);
                    break;
                default:
                    break;
            }
        }
    }
}
