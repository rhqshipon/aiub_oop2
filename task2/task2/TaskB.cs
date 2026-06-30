using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    internal class TaskB
    {
        public void MatrixSum()
        {
            int[,] matrix = new int[3, 3];

            Console.WriteLine("Enter elements of 3x3 matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;

            Console.WriteLine("Matrix Elements:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    sum += matrix[i, j];
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Sum of all elements: {sum}");
        }
    }
}
