using System;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("No input provided.");
            return;
        }

        string[] words = input.Split(' '); 
        Action<string> printWord = word => Console.WriteLine(word);

        foreach (string word in words)
        {
            printWord(word);
        }
    }
}
