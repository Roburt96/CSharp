namespace BlindManBuff
{
    class BlindMan
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splitInput = input.Split();
            var rows = int.Parse(splitInput[0]);
            var cols = int.Parse(splitInput[1]);

            var pRow = 0; var pCol = 0; var moveCouter = 0; var touchedPlayer = 0;

            string[][] matrix = new string[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == "B")
                    {
                        pRow = i;
                        pCol = j;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                moveCouter++;

                if (command == "left")
                {
                    pCol--;
                }
                else if (command == "right")
                {
                    pCol++;
                }
                else if (command == "up")
                {
                    pRow--;
                }
                else if (command == "down")
                {
                    pRow++;
                }

                if (IsValidCoordinate(pRow, pCol, rows, cols) && matrix[pRow][pCol] == "P")
                {
                    touchedPlayer++;
                }
            }

            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touchedPlayer} Moves made: {moveCouter}");


            static bool IsValidCoordinate(int row, int col, int rows, int cols)
            {
                return row >= 0 && row < rows && col >= 0 && col < cols;
            }

            
        }
    }
}