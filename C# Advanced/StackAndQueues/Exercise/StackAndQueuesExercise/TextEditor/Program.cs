using System;
using System.Collections.Generic;

class SimpleTextEditor
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); 
        Stack<string> history = new Stack<string>(); 
        string text = string.Empty; 
        history.Push(text);

        for (int i = 0; i < n; i++)
        {
            var inputs = Console.ReadLine().Split(' ');
            string command = inputs[0]; 

            switch (command)
            {
                case "1":
                    string appendString = inputs[1];
                    text += appendString;
                    history.Push(text);
                    break;

                case "2":
                    int count = int.Parse(inputs[1]);
                    text = text.Substring(0, text.Length - count);
                    history.Push(text);
                    break;

                case "3":
                    int index = int.Parse(inputs[1]);
                    Console.WriteLine(text[index - 1]);
                    break;

                case "4":
                    if (history.Count > 1)
                    {
                        history.Pop();
                        text = history.Peek();
                    }
                    break;
            }
        }
    }
}
