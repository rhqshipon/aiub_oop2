using System;
using System.Collections.Generic;
using System.Text;

namespace oop2_day1_ConsoleApp1
{
    public class Class1x
    {
        public void test1() {Console.WriteLine("test 1 called!");}

        public void test2() {Console.WriteLine("test 2 called!");}

        public void testforloop1()  {
            for (int i = 0; i <= 10; i++ )  {
                Console.WriteLine("test for loop1 called: " + i);
            }
        }

        public void testwhileloop1()    {
            int i = 0;
            while (i <= 10) {
                Console.WriteLine("test while loop1 called: " + i);
                i++;
            }
        }

        public void testdowhileloop1()  {
            int i = 0;
            do {
                Console.WriteLine("test do while loop1 called: " + i);
                i++;
            }
            while (i <= 10);
        }
        public String name = null;
        public void inputtest()        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            //Console.WriteLine("Name: " + name);
        }
    }
    public class Class2x {
        public String phone_number = null;
        public void inputtest() {
            Console.Write("Enter your phone number: ");
            phone_number = Console.ReadLine();
            //Console.WriteLine("Phone Number: " + phone_number);
        }

    }

    public class Class3x    {
        public void inputtest() {
            //Console.WriteLine("Showing stored data: ");
            Class1x c1 = new Class1x();
            Class2x c2 = new Class2x();
            c1.inputtest();
            c2.inputtest();
            Console.WriteLine("Phone Number: " + c1.name);
            Console.WriteLine("Phone Number: " + c2.phone_number);
            Console.WriteLine($"Hello, {c1.name}");
            Console.WriteLine($"Your phone number is: {c2.phone_number}");
            //String phone_number = Console.ReadLine();
        }

    }

    public class Class4x { 
        public void test() {
            double number = 10.5465413;
            Console.WriteLine(String.Format("The Number is {0}", number));
        }
    }

}
