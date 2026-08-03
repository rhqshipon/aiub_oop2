using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    public class Task1
    {
        public void forloop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("For loop iterating: " + i);
            }
            Console.WriteLine();
        }

        public void whileloop()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("While loop iterating: " + i);
                i++;
            }
            Console.WriteLine();
        }

        public void dowhileloop()
        {
            int i = 1;
            do
            {
                Console.WriteLine("Do while loop iterating: " + i);
                i++;
            }
            while (i <= 10);
            Console.WriteLine();
        }

    }
}
