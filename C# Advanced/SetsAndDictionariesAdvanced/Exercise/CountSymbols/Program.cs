namespace DictionariesAndSets
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var countSymbols = new SortedDictionary<string, int>(StringComparer.Ordinal);

            foreach (var sym in input)
            {
                if (countSymbols.ContainsKey(sym.ToString()))
                    countSymbols[sym.ToString()]++;
                else
                    countSymbols[sym.ToString()] = 1;
            }

            foreach (KeyValuePair<string, int> pair in countSymbols)
            {
                string key = pair.Key;
                int value = pair.Value;
                Console.WriteLine($"{key}: {value} time/s");
            }
        }
    }
}