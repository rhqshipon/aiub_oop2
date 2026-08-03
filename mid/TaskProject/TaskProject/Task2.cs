using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    internal class Task2
    {
        private double number;

        internal Task2(double number)
        {
            this.number = number;
        }

        internal void display()
        {
            Console.Write(number);
            Console.WriteLine();
            Console.WriteLine("The number is: " + number);
            Console.WriteLine($"The number is: {number}");
            Console.WriteLine(String.Format("The number is: {0}", number));
        }
    }
}

