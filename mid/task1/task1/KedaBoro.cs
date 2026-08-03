using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class KedaBoro
    {
        public double number;

        public KedaBoro()
        {
        }
        public KedaBoro(double number)
        {
            this.number = number;
        }

        internal void checkKedaBoro()
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }

}
