using System;

class ArrayAndMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        int[] rowMajor = new int[rows * cols];
        int[] colMajor = new int[rows * cols];


        Console.WriteLine("\nEnter matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                rowMajor[k++] = matrix[i, j];
            }
        }


        k = 0;
        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                colMajor[k++] = matrix[i, j];
            }
        }


        Console.WriteLine("\nMatrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nRow-major order array:");
        foreach (int val in rowMajor)
            Console.Write(val + " ");

        Console.WriteLine("\n\nColumn-major order array:");
        foreach (int val in colMajor)
            Console.Write(val + " ");

        Console.WriteLine();
    }
}
