namespace DictionariesAndSets
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            var totalNames = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();

            for (int i = 0; i < totalNames; i++)
            {
                set.Add(Console.ReadLine());
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }

        }
    }
}