namespace StackAndQueuesExercise
{
    class FastFood
    {
        static void Main(string[] args)
        {
            var quantity = int.Parse(Console.ReadLine());
            var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            var dayBiggestOrder = queue.Max();
            while (queue.Count > 0 && quantity >= queue.Peek())
            {
                quantity -= queue.Dequeue();
            }

            Console.WriteLine(dayBiggestOrder);

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(", ", queue)}");
            }
        }
    }
}