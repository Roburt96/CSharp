namespace DictionariesAndSets
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var counts = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            int result = counts.FirstOrDefault(k => k.Value % 2 == 0).Key;

            Console.WriteLine(result);
        }
    }
}