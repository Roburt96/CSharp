using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        char[,] field = new char[N, N];

        int playerRow = -1;
        int playerCol = -1;
        for (int row = 0; row < N; row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < N; col++)
            {
                field[row, col] = line[col];
                if (line[col] == 'P')
                {
                    playerRow = row;
                    playerCol = col;
                }
            }
        }

        int playerHealth = 100;
        bool isPlayerAlive = true;
        string command;
        while ((command = Console.ReadLine()) != null && command != "")
        {
            int nextRow = playerRow;
            int nextCol = playerCol;

            if (command == "up")
            {
                nextRow--;
            }
            else if (command == "down")
            {
                nextRow++;
            }
            else if (command == "left")
            {
                nextCol--;
            }
            else if (command == "right")
            {
                nextCol++;
            }

            if (!IsValidPosition(nextRow, nextCol, N))
            {
                continue;
            }

            if (field[nextRow, nextCol] == 'M')
            {
                playerHealth -= 40;
                if (playerHealth <= 0)
                {
                    playerHealth = 0;
                    isPlayerAlive = false;
                    field[nextRow, nextCol] = 'P';
                    break;
                }
            }
            else if (field[nextRow, nextCol] == 'H')
            {
                playerHealth += 15;
                if (playerHealth > 100)
                {
                    playerHealth = 100;
                }
            }
            else if (field[nextRow, nextCol] == 'X')
            {
                isPlayerAlive = true;
                field[nextRow, nextCol] = 'P';
                break;
            }
            field[playerRow, playerCol] = '-';
            playerRow = nextRow;
            playerCol = nextCol;
        }
        Console.WriteLine(isPlayerAlive ? "Player escaped the maze. Danger passed!" : "Player is dead. Maze over!");
        Console.WriteLine($"Player's health: {playerHealth} units");
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                Console.Write(field[row, col]);
            }
            Console.WriteLine();
        }
    }

    static bool IsValidPosition(int row, int col, int N)
    {
        return row >= 0 && row < N && col >= 0 && col < N;
    }
}