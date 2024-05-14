namespace DictinariesAndSets
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothesDict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.None);
                string color = parts[0];
                string[] cloths = parts[1].Split(',');

                if (!clothesDict.ContainsKey(color))
                {
                    clothesDict[color] = new Dictionary<string, int>();
                }

                foreach (string cloth in cloths)
                {
                    if (!clothesDict[color].ContainsKey(cloth))
                    {
                        clothesDict[color][cloth] = 0;
                    }

                    clothesDict[color][cloth]++;
                }
            }

            string[] searchInput = Console.ReadLine().Split();
            string searchColor = searchInput[0];
            string searchCloth = searchInput[1];

            foreach (var color in clothesDict)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (item.Key == searchCloth && color.Key == searchColor)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}