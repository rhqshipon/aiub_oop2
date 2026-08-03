using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    public class Menu
    {
        private int choice;

        private static void SafeClear()
        {
            try
            {
                if (!Console.IsOutputRedirected)
                {
                    Console.Clear();
                }
            }
            catch (IOException)
            {
            }
            catch (PlatformNotSupportedException)
            {
            }
        }

        public void menu()
        {
            while (true)
            {
                SafeClear();
                Console.WriteLine("\nOOP2 Lab 1 Task Viewer");
                Console.WriteLine("[1] Task 1: Loop Related Problems");
                Console.WriteLine("[2] Task 2: Console.Writeline functionalities");
                Console.WriteLine("[3] Task 3: Taking user input");
                Console.WriteLine("[4] Task 4: If Else statement test, Even Odd checker");
                Console.WriteLine("[5] Task 5: Diamond");
                Console.WriteLine("[6] Task 6: Grade Generator");
                Console.WriteLine("[7] Task 7: Person Object");
                Console.WriteLine("[8] Task 8: Debugging");
                Console.WriteLine("[0] Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out this.choice))
                {
                    // valid number
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                Console.WriteLine();

                switch (this.choice)
                {
                    case 1:
                        Task1 t1 = new Task1();
                        t1.forloop();
                        t1.whileloop();
                        t1.dowhileloop();
                        break;

                    case 2:
                        // Task 2
                        Task2 t2 = new Task2(2.25);
                        t2.display();
                        break;

                    case 3:
                        Task3 t3 = new Task3();
                        t3.GetUserInput();
                        break;

                    case 4:
                        Task4 t4 = new Task4();
                        t4.menutest(1);
                        break;

                    case 5:
                        Console.WriteLine("Diamond pattern for n = 9:");
                        Task5 t5 = new Task5();
                        t5.PrintDiamond(3);
                        break;

                    case 6:
                        Task6 t6 = new Task6();
                        t6.GetGrade(70);
                        break;

                    case 7:
                        Person p1 = new Person();
                        p1.name = "John Doe";
                        p1.age = 20;
                        p1.display();
                        break;

                    case 8:
                        Console.WriteLine("Diamond pattern for n = 5:");
                        Task8 t8 = new Task8();
                        t8.PrintDiamond(5);
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        return;   // exits the menu method

                    default:
                        Console.WriteLine("Invalid input entered.");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                SafeClear();
            }
        }
    }


}

