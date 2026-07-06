using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class ArrayAnalyzer
    {
        private int[] numbers;
        private int size;

        public void ReadElements()
        {
            Console.Write("Enter size: ");
            size = int.Parse(Console.ReadLine());

            numbers = new int[size];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        public void FindAndPrintLargest()
        {
            int max = numbers[0];

            for (int i = 1; i < size; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"Largest element: {max}");
        }
    }

    internal class TaskA
    {
        public void FindLargest()
        {
            ArrayAnalyzer analyzer = new ArrayAnalyzer();

            analyzer.ReadElements();
            analyzer.FindAndPrintLargest();
        }
    }
}