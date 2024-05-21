namespace ClearSkies
{
    class ClearSkies
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            char[][] matrix = new char[input][];
            var armour = 300;
            var pRow = 0; var pCol = 0;
            var enemyPlane = 0;

            for (int i = 0; i < input; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (matrix[i][j] == 'J')
                    {
                        pRow = i;
                        pCol = j;
                        matrix[pRow][pCol] = '-';
                    }
                    if (matrix[i][j] == 'E')
                    {
                        enemyPlane++;
                    }
                }
            }

            while (enemyPlane > 0 && armour > 0)
            {
                string command = Console.ReadLine();
                int newRow = pRow;
                int newCol = pCol;

                switch (command)
                {
                    case "left":
                        newCol--;
                        break;
                    case "right":
                        newCol++;
                        break;
                    case "up":
                        newRow--;
                        break;
                    case "down":
                        newRow++;
                        break;
                }

                if (IsValidCoordinate(newRow, newCol, input, input))
                {
                    pRow = newRow;
                    pCol = newCol;

                    if (matrix[pRow][pCol] == 'E')
                    {
                        if (enemyPlane > 0)
                        {
                            matrix[pRow][pCol] = '-';
                            enemyPlane--;
                            armour -= 100;
                        }
                    }
                    else if (matrix[pRow][pCol] == 'R')
                    {
                        matrix[pRow][pCol] = '-';
                        armour = 300;
                    }
                }
                if (enemyPlane == 0)
                {
                    Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                    matrix[pRow][pCol] = 'J';
                    break;
                }

                if (armour == 0)
                {
                    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{pRow}, {pCol}]!");
                    matrix[pRow][pCol] = 'J';
                    break;
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(new string(row));
            }
        }

        static bool IsValidCoordinate(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
    }
}
