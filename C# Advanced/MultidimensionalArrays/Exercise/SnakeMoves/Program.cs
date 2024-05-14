namespace MultidimensionalArrays
{
    class SnakeMoves
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            int rows = int.Parse(inputs[0]);
            int cols = int.Parse(inputs[1]);

            string snake = Console.ReadLine();

            char[][] matrix = new char[rows][];
            int snakeIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row][col] = snake[snakeIndex];
                        snakeIndex = (snakeIndex + 1) % snake.Length;
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row][col] = snake[snakeIndex];
                        snakeIndex = (snakeIndex + 1) % snake.Length;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}