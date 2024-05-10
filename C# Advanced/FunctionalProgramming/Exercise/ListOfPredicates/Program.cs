using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool IsDivisibleByAll(int number, List<int> divisors)
    {
        foreach (int divisor in divisors)
        {
            if (divisor == 0 || number % divisor != 0)
            {
                return false; 
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        int N;
        string nInput = Console.ReadLine();
        if (int.TryParse(nInput, out N) && N > 0) 
        {
            string[] divisorsInput = Console.ReadLine().Split(' ');
            List<int> divisors = new List<int>();
            foreach (string item in divisorsInput)
            {
                if (int.TryParse(item, out int divisor))
                {
                    divisors.Add(divisor);
                }
                else
                {
                    return;
                }
            }

            List<int> result = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                if (IsDivisibleByAll(i, divisors))
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
