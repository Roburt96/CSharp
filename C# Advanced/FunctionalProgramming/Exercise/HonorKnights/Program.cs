using System;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        Action<string> printWord = word => Console.WriteLine($"Sir {word}");

        foreach (string word in words)
        {
            printWord(word);
        }
    }
}
