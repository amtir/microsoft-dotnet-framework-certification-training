using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input first matrix size
            Console.Write("Enter the number of rows for the first matrix: ");
            int row1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns for the first matrix: ");
            int col1 = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[row1, col1];

            // Input second matrix size
            Console.Write("Enter the number of rows for the second matrix: ");
            int row2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns for the second matrix: ");
            int col2 = Convert.ToInt32(Console.ReadLine());

            int[,] matrix2 = new int[row2, col2];

            // Validate multiplication condition
            if (col1 != row2)
            {
                Console.WriteLine("Matrix multiplication is not possible. Columns of first matrix must equal rows of second matrix.");
                return;
            }

            // Input first matrix elements
            Console.WriteLine("Input elements in the first matrix:");
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Input second matrix elements
            Console.WriteLine("Input elements in the second matrix:");
            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Multiply matrices
            int[,] result = new int[row1, col2];

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < col1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            // Print first matrix
            Console.WriteLine("\nThe First matrix is:");
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Print second matrix
            Console.WriteLine("\nThe Second matrix is:");
            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Print result matrix
            Console.WriteLine("\nThe multiplication of two matrices is:");
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
