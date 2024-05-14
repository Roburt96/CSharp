namespace MultidimenstionalArrays
{
    class KnightGame
    {
        private static readonly (int, int)[] position =
        {
        (-2, -1),  // up left
        (-2, 1),   // up right
        (-1, -2),  // left up
        (-1, 2),   // right up
        (1, -2),   // left down
        (1, 2),    // right down
        (2, -1),   // down left
        (2, 1)     // down right
    };

        private int size;
        private char[][] matrixTable;
        private int removed;
        private List<int[]> removedHorse;

        public KnightGame()
        {
            this.size = int.Parse(Console.ReadLine());
            this.matrixTable = new char[this.size][];
            this.removedHorse = new List<int[]>();
            this.ReadMatrix();
            this.CheckHits();
            Console.WriteLine(this.removed);
        }

        private void ReadMatrix()
        {
            for (int i = 0; i < this.size; i++)
            {
                this.matrixTable[i] = Console.ReadLine().ToCharArray();
            }
        }

        private void CheckHits()
        {
            while (true)
            {
                int maxHits = 0;
                for (int row = 0; row < this.size; row++)
                {
                    for (int col = 0; col < this.size; col++)
                    {
                        if (this.matrixTable[row][col] == 'K')
                        {
                            int[] currentHorse = { row, col };
                            int currentHits = 0;
                            foreach (var move in position)
                            {
                                int horseRow = row + move.Item1;
                                int horseCol = col + move.Item2;
                                if (IsValidMove(horseRow, horseCol) && this.matrixTable[horseRow][horseCol] == 'K')
                                {
                                    currentHits++;
                                }
                            }
                            if (currentHits > maxHits)
                            {
                                maxHits = currentHits;
                                this.removedHorse = new List<int[]>(1) { currentHorse };
                            }
                        }
                    }
                }
                if (maxHits > 0)
                {
                    this.matrixTable[this.removedHorse[0][0]][this.removedHorse[0][1]] = '0';
                    this.removed++;
                }
                else
                {
                    break;
                }
            }
        }

        private bool IsValidMove(int row, int col)
        {
            return row >= 0 && row < this.size && col >= 0 && col < this.size;
        }

        static void Main()
        {
            KnightGame knight = new KnightGame();
        }
    }
}