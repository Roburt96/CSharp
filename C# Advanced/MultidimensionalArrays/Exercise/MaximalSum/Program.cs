namespace MultidimensionalArrays
{
    class MaximalSum
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }

            int maxSum = int.MinValue;
            int maxSumRow = -1;
            int maxSumCol = -1;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = 0;
                    for (int r = row; r < row + 3; r++)
                    {
                        for (int c = col; c < col + 3; c++)
                        {
                            sum += matrix[r][c];
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int r = maxSumRow; r < maxSumRow + 3; r++)
            {
                for (int c = maxSumCol; c < maxSumCol + 3; c++)
                {
                    Console.Write(matrix[r][c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}