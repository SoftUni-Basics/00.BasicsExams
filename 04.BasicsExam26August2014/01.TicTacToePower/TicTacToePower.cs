using System;

class TicTacToePower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int start = int.Parse(Console.ReadLine());

        int[,] matrix = new int[3, 3];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = start;
                start++;
            }
        }

        long power = (y * 3) + (x + 1);

        long result = (long)Math.Pow(matrix[y, x], power);

        Console.WriteLine(result);
    }
}
