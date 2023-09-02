using System;

namespace lab_dotnet
{
    class MultiDimensional
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the first matrix (row, column):");
            int m1 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the elements of the first matrix:");
            int[,] matrix1 = new int[m1, n1];
            for (int i = 0; i < m1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the size of the second matrix (row, column):");
            int m2 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the elements of the second matrix:");
            int[,] matrix2 = new int[m2, n2];
            for (int i = 0; i < m2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Check if matrix multiplication is possible
            if (n1 != m2)
            {
                Console.WriteLine("Multiplication is not possible.");
                Console.WriteLine();
                Console.WriteLine("Lab No.: 3.c  Roll no: 23957 \n Name:Bibek Angdembe");
            }
            else
            {
                // Multiply the matrices
                int[,] resultMatrix = new int[m1, n2];
                for (int i = 0; i < m1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        for (int k = 0; k < n2; k++)
                        {
                            resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
                // Display the result matrix
                Console.WriteLine("The result matrix is:");
                for (int i = 0; i < m1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        Console.Write(resultMatrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Lab No.: 3.c  Roll no: 23957 \n Name:Bibek Angdembe");
        }
    }
}