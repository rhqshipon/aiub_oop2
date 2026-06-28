using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    internal class Person
    {
        internal string name { set; get; } = string.Empty;
        internal int age { set; get; }

        internal void display()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
