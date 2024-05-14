namespace DictionariesAndSets
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            var inputLines = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();

            for (int i = 0; i < inputLines;  i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                foreach(var chemical in input)
                {
                    set.Add(chemical);
                }

            }
            Console.WriteLine(string.Join(' ', set.OrderBy(x => x)));

        }
    }
}