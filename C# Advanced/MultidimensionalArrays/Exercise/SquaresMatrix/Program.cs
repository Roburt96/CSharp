namespace MultidimensionalArrays
{
    class SquaresMatrix
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            string[][] matrix = new string[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split();
            }

            int find = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (0 <= row + 1 && row + 1 < rows && 0 <= col + 1 && col + 1 < cols)
                    {
                        int count = 0;
                        string symbol = matrix[row][col];
                        for (int r = row; r <= row + 1; r++)
                        {
                            for (int c = col; c <= col + 1; c++)
                            {
                                if (matrix[r][c] == symbol)
                                {
                                    count++;
                                }
                            }
                        }
                        if (count == 4)
                        {
                            find++;
                        }
                    }
                }
            }

            Console.WriteLine(find);
        }
    }
}