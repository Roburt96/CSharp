using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> invitations = Console.ReadLine().Split().ToList();
        Dictionary<string, Func<string, bool>> filters = new Dictionary<string, Func<string, bool>>();

        string command;
        while ((command = Console.ReadLine()) != "Print")
        {
            string[] commandParts = command.Split(';');
            string action = commandParts[0];
            string filterType = commandParts[1];
            string filterParameter = commandParts[2];

            string filterKey = $"{filterType};{filterParameter}";
            Func<string, bool> filterFunction = filterType switch
            {
                "Starts with" => name => name.StartsWith(filterParameter),
                "Ends with" => name => name.EndsWith(filterParameter),
                "Length" => name => name.Length == int.Parse(filterParameter),
                "Contains" => name => name.Contains(filterParameter),
                _ => throw new InvalidOperationException("Unknown filter type")
            };

            if (action == "Add filter")
            {
                filters[filterKey] = filterFunction;
            }
            else if (action == "Remove filter")
            {
                filters.Remove(filterKey); 
            }
        }

        List<string> filteredInvitations = invitations .Where(invitation => !filters.Values.Any(filter => filter(invitation))).ToList();

        Console.WriteLine(string.Join(" ", filteredInvitations));
    }
}
