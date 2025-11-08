using System;

class ArrayAndMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of rows in Matrix A: ");
        int rowsA = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns in Matrix A (and rows in Matrix B): ");
        int colsA_rowsB = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns in Matrix B: ");
        int colsB = int.Parse(Console.ReadLine());

        int[,] A = new int[rowsA, colsA_rowsB];
        int[,] B = new int[colsA_rowsB, colsB];
        int[,] C = new int[rowsA, colsB];

        Console.WriteLine("\nEnter elements of Matrix A:");
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsA_rowsB; j++)
            {
                Console.Write($"A[{i},{j}] = ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nEnter elements of Matrix B:");
        for (int i = 0; i < colsA_rowsB; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                Console.Write($"B[{i},{j}] = ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Matrix Multiplication Logic
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < colsA_rowsB; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        // Print Result
        Console.WriteLine("\nMatrix A:");
        PrintMatrix(A);

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(B);

        Console.WriteLine("\nResultant Matrix C (A × B):");
        PrintMatrix(C);
    }

    // Helper function to print a 2D matrix
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
