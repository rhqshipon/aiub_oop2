using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    public class Task3
    {
        // Fields to store user information
        public string name = string.Empty;
        public int age;

        public void GetUserInput()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine($"Hello, {name}! You are {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number for age.");
            }
        }
    }

}
