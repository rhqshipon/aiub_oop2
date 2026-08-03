using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    internal struct Book
    {
        internal string Title;
        internal string Author; 
        internal double Price;
    }

    internal class BookManager
    {
        private Book[] books = new Book[2];
        public void AddBooks()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"\nEntering details for Book {i + 1}:");
                Console.Write("Enter Title: ");
                string title = Console.ReadLine();
                Console.Write("Enter Author: ");
                string author = Console.ReadLine();
                Console.Write("Enter Price: ");
                double price = double.Parse(Console.ReadLine());
                books[i] = new Book { Title = title, Author = author, Price = price };
            }
        }
        public void DisplayBookData()
        {
            Console.WriteLine("\n--- Book Records ---");

            foreach (Book b in books)
            {
                if (b.Price > 20.0)
                {
                    Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Price: {b.Price}");
                }
            }
        }
    }
}
