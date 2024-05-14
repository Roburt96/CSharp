namespace DictionariesAndSets
{
    class ElementsSets
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split(' ');
            var n = int.Parse(elements[0]);
            var m = int.Parse(elements[1]);
            var listOfElementsN = new List<int>();
            var listOfElementsM = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var ele = Console.ReadLine();
                listOfElementsN.Add(int.Parse(ele));
            }
            for (int i = 0; i < m; i++)
            {
                var ele = Console.ReadLine();
                listOfElementsM.Add(int.Parse(ele));
            }
            var commonElements = listOfElementsN.Intersect(listOfElementsM);

            Console.WriteLine(string.Join(' ', commonElements));
        }
    }
}