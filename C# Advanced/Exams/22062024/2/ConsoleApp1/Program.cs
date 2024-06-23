using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] field = new char[n, n];
        int beeRow = 0, beeCol = 0;
        int collectedNectar = 0;
        int energy = 15;
        bool restoredEng = false;

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                field[i, j] = line[j];
                if (field[i, j] == 'B')
                {
                    beeRow = i;
                    beeCol = j;
                }
            }
        }

        string command;
        while ((command = Console.ReadLine()) != null)
        {
            field[beeRow, beeCol] = '-';
            (beeRow, beeCol) = Move(beeRow, beeCol, command, n);
            energy--;

            if (beeRow < 0 || beeRow >= n || beeCol < 0 || beeCol >= n)
            {
                (beeRow, beeCol) = WrapAround(beeRow, beeCol, n);
            }

            if (field[beeRow, beeCol] == 'H')
            {
                field[beeRow, beeCol] = 'B';
                if (collectedNectar >= 30)
                {
                    Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
                }
                else
                {
                    Console.WriteLine("Beesy did not manage to collect enough nectar.");
                }
                PrintField(field);
                return;
            }
            else if (char.IsDigit(field[beeRow, beeCol]))
            {
                collectedNectar += field[beeRow, beeCol] - '0';
            }

            field[beeRow, beeCol] = 'B';

            if (energy == 0)
            {
                if (!restoredEng && collectedNectar >= 30)
                {
                    int excessNectar = collectedNectar - 30;
                    energy += excessNectar;
                    collectedNectar = 30;
                    restoredEng = true;
                }

                if (energy == 0)
                {
                    Console.WriteLine("This is the end! Beesy ran out of energy.");
                    PrintField(field);
                    return;
                }
            }
        }
    }

    static (int, int) Move(int row, int col, string direction, int size)
    {
        switch (direction)
        {
            case "up": return (row - 1, col);
            case "down": return (row + 1, col);
            case "left": return (row, col - 1);
            case "right": return (row, col + 1);
            default: return (row, col);
        }
    }

    static (int, int) WrapAround(int row, int col, int size)
    {
        row = (row < 0) ? size - 1 : (row >= size) ? 0 : row;
        col = (col < 0) ? size - 1 : (col >= size) ? 0 : col;
        return (row, col);
    }


    static void PrintField(char[,] field)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                Console.Write(field[i, j]);
            }
            Console.WriteLine();
        }
    }
}
