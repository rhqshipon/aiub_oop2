using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    public class Task6
    {
        public void GetGrade(int score)
        {
            char grade;

            switch (score)
            {
                case int n when (n >= 90 && n <= 100):
                    grade = 'A';
                    break;

                case int n when (n >= 80 && n < 90):
                    grade = 'B';
                    break;

                case int n when (n >= 70 && n < 80):
                    grade = 'C';
                    break;

                case int n when (n >= 50 && n < 70):
                    grade = 'D';
                    break;

                case int n when (n >= 0 && n < 50):
                    grade = 'F';
                    break;

                default:
                    Console.WriteLine("Invalid score entered.");
                    return;
            }

            display(score, grade);
        }

        private void display(float score, char grade)
        {
            Console.WriteLine($"Obtained Score: {score}");
            Console.WriteLine($"Obtained Grade: {grade}");
        }
    }
}
