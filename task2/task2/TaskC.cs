using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    internal class TaskC
    {
        public void JaggedArray()
        {
            Console.Write("Enter number of students: ");
            int studentCount = int.Parse(Console.ReadLine());

            int[][] marks = new int[studentCount][];

            int highestTotal = 0;
            int highestStudent = 0;

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"Student {i + 1} subjects: ");
                int subjectCount = int.Parse(Console.ReadLine());

                marks[i] = new int[subjectCount];

                Console.Write("Marks: ");

                for (int j = 0; j < subjectCount; j++)
                {
                    marks[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < studentCount; i++)
            {
                int total = 0;

                for (int j = 0; j < marks[i].Length; j++)
                {
                    total += marks[i][j];
                }

                Console.WriteLine($"Total of Student {i + 1}: {total}");

                if (total > highestTotal)
                {
                    highestTotal = total;
                    highestStudent = i + 1;
                }
            }

            Console.WriteLine(
                $"Highest Scoring Student: Student {highestStudent} with {highestTotal} marks"
            );
        }
    }
}
