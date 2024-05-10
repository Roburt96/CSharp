namespace StackAndQueueExercise
{
    class FashionBoutique
    {
        static void Main(string[] args)
        {
            Stack<int> stackOfClothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacityPerRack = int.Parse(Console.ReadLine());

            int totalRacks = 0;
            int currentCapacity = 0;

            while (stackOfClothes.Count > 0)
            {
                int currentCloth = stackOfClothes.Pop();
                if (currentCapacity + currentCloth <= capacityPerRack)
                {
                    currentCapacity += currentCloth;
                }
                else
                {
                    totalRacks++;
                    currentCapacity = currentCloth;
                }
            }
            if (currentCapacity > 0)
            {
                totalRacks++;
            }

            Console.WriteLine(totalRacks);
        }
    }
}