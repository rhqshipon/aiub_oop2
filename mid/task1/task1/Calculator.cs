using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class Calculator
    {
        private double a { get; set; }
        private double b { get; set; }

        public Calculator(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        internal double add()
        {
            return a + b;
        }

        internal double substract()
        {
            return a - b;
        }

        internal double multiply()
        {
            return a * b;
        }

        internal double divide()
        {
            return a / b;
        }

        internal void display()
        {
            Console.WriteLine($"A: {a}");
            Console.WriteLine($"B: {b}");
            Console.WriteLine("Addition: " + add());
            Console.WriteLine("Substraction: " + substract());
            Console.WriteLine("Multiplication: " + multiply());
            Console.WriteLine("Division: " + divide());
        }
    }
}
