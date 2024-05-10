using System.Linq;

namespace StackAndQueueLab
{
    class QueueOperations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            var totalElements = int.Parse(input[0]);
            var elementsToRemove = int.Parse(input[1]);
            var element = int.Parse(input[2]);

            var min = queue.Min();

            for (int i = 0; i < elementsToRemove; i++)
            {
                queue.Dequeue();
            }
           
            
            bool isExist = queue.Contains(element);

            if (isExist)
            {
                Console.WriteLine($"true");
            }
            else
            {
                if (queue.Any())
                {
                    Console.WriteLine(min);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}