using System;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueuesExercise
{
    class MaxAndMinElement
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            int totalInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalInputs; i++)
            {
                var inputs = Console.ReadLine().Split().ToArray();
                var command = int.Parse(inputs[0]);

                switch (command)
                {
                    case 1:
                        int value = int.Parse(inputs[1]);
                        stack.Push(value);
                        break;

                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;

                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;

                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }
            if (stack.Count > 0)
            {
                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}
