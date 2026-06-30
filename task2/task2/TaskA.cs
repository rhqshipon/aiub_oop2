using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    internal class TaskA
    {
        public void FindLargest()
        {
            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("Enter elements:");

            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

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
}
