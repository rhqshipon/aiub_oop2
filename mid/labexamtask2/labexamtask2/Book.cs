using System;
using System.Collections.Generic;
using System.Text;

namespace labexamtask2
{
    internal class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(int bookId, string title, string author)
        {
            BookID = bookId;
            Title = title;
            Author = author;
        }
    }
}
