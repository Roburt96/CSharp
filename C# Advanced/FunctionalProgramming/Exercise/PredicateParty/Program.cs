using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> guests = Console.ReadLine().Split().ToList();

        string command;
        while ((command = Console.ReadLine()) != "Party!")
        {
            string[] commandParts = command.Split();
            string action = commandParts[0];
            string criteria = commandParts[1];
            string value = commandParts[2];

            if (action == "Remove")
            {
                if (criteria == "StartsWith")
                {
                    guests.RemoveAll(g => g.StartsWith(value));
                }
                else if (criteria == "EndsWith")
                {
                    guests.RemoveAll(g => g.EndsWith(value));
                }
                else if (criteria == "Length")
                {
                    if (int.TryParse(value, out int length))
                    {
                        guests.RemoveAll(g => g.Length == length);
                    }
                }
            }
            else if (action == "Double")
            {
                List<string> toDouble = new List<string>();
                if (criteria == "StartsWith")
                {
                    toDouble = guests.Where(g => g.StartsWith(value)).ToList();
                }
                else if (criteria == "EndsWith")
                {
                    toDouble = guests.Where(g => g.EndsWith(value)).ToList();
                }
                else if (criteria == "Length")
                {
                    if (int.TryParse(value, out int length))
                    {
                        toDouble = guests.Where(g => g.Length == length).ToList();
                    }
                }
                guests.AddRange(toDouble);
            }
        }

        if (guests.Count > 0)
        {
            Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }
}
