using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    public class Task8
    {
        
        public void PrintDiamond(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                //Console.Write("");

                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }

                
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

               
                Console.WriteLine();
            }

            
            for (int i = n - 1; i >= 1; i--)
            {
                
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }

                
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                
                Console.WriteLine();
            }
        }
    }
   
}