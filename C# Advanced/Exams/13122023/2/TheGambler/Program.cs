namespace TheGambler
{
    class Gambler
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            char[][] matrix = new char[input][];
            var pRow = 0; var pCol = 0; var amount = 100;

            for (int i = 0; i < input; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (matrix[i][j] == 'G')
                    {
                        pRow = i;
                        pCol = j;
                        matrix[pRow][pCol] = '-';
                    }
                }
            }

            
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end") { break; }

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

                if (amount <= 0)
                {
                    break;
                }
                if (amount >= 100000)
                {
                    break;
                }

                if (matrix[pRow][pCol] == 'W')
                {
                    amount += 100;
                    matrix[pRow][pCol] = '-';
                }
                else if (matrix[pRow][pCol] == 'P')
                {
                    amount -= 200;
                    matrix[pRow][pCol] = '-';
                }
                else if (matrix[pRow][pCol] == 'J')
                {
                    amount += 100000;
                    matrix[pRow][pCol] = '-';
                    Console.WriteLine("You win the Jackpot!");
                }
                if (amount <= 0)
                {
                    break;
                }
                if (amount >= 100000)
                {
                    break;
                }

            }
             matrix[pRow][pCol] = 'G';
            if (amount > 0)
            {
                Console.WriteLine($"End of the game. Total amount: {amount}$");
                foreach(var row in  matrix)
                {
                    Console.WriteLine(new string(row));
                }
            }
            else { Console.WriteLine("Game Over! You lost everythink!"); }


        }

        





        static bool Coordinate(int row, int col, int rows, int cols)
        {
            return row < 0 && row > rows && col < 0 && col > cols;
        }
    }
}