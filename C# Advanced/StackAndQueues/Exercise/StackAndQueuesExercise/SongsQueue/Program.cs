using System;
using System.Collections.Generic;

namespace StackAndQueuesExercice
{
    class SongsQueue
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>(Console.ReadLine().Split(", "));

            while (queue.Count > 0)
            {
                var input = Console.ReadLine();
                var commandParts = input.Split(' ', 2);

                var command = commandParts[0]; 
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Add")
                {
                    if (commandParts.Length < 2) 
                    {
                        continue;
                    }

                    var song = commandParts[1];

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

            }

            if (queue.Count == 0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
