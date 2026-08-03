using System;

namespace labexamtask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Issued Book Information:\n");

            Console.Write("Enter Book ID: ");
            int bookId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Student ID: ");
            string studentId = Console.ReadLine();

            Console.Write("Enter Issue Date (in the format, DD/MM/YYYY): ");
            string issueDate = Console.ReadLine();

            Console.Write("Enter Fine Amount: ");
            double fineAmount = Convert.ToDouble(Console.ReadLine());

            IssuedBook myIssuedBook = new IssuedBook(bookId, title, author, studentId, issueDate, fineAmount);

            myIssuedBook.DisplayInformation();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}