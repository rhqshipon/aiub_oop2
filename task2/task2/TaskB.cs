using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Matrix
    {
        private int[,] data = new int[3, 3];

        public void ReadElements()
        {
            Console.WriteLine("Enter elements of 3x3 matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void PrintAndSum()
        {
            int sum = 0;
            Console.WriteLine("Matrix Elements:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(data[i, j] + " ");
                    sum += data[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Sum of all elements: {sum}");
        }
    }

    internal class TaskB
    {
        public void MatrixSum()
        {
            Matrix myMatrix = new Matrix();

            myMatrix.ReadElements();
            myMatrix.PrintAndSum();
        }
    }
}