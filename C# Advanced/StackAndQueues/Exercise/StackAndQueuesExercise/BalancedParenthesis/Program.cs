using System;
using System.Collections.Generic;

class BalancedParentheses
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        bool isBalanced = IsBalanced(input);

        Console.WriteLine(isBalanced ? "YES" : "NO");
    }

    static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();
        var matchingBrackets = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char c in input)
        {
            if (matchingBrackets.ContainsValue(c))
            {
                stack.Push(c);
            }
            else if (matchingBrackets.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Pop() != matchingBrackets[c])
                {
                    return false;
                }
            }
            else
            {

                return false;
            }
        }

        return stack.Count == 0;
    }
}
