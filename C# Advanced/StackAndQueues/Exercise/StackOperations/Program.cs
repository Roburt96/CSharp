namespace StackAndQueuesExercise
{
    class StackOperations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray() ;
            var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            var elements = int.Parse(input[0]);
            var elementsToDrop = int.Parse(input[1]);
            var elementIsExist = int.Parse(input[2]);
           
            for (int i = 0; i < elementsToDrop; i++) {
                stack.Pop();
            }
            bool checkExist = stack.Contains(elementIsExist);
            if (checkExist )
            {
                Console.WriteLine($"true");
            }
            else
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }




        }
    }
}