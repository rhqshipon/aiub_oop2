using System;
using System.Collections.Generic;
using System.Text;

namespace labexamtask2
{
    internal class IssuedBook : Book
    {
        public string StudentID { get; set; }
        public string IssueDate { get; set; }
        public double FineAmount { get; set; }

        public IssuedBook(int bookId, string title, string author, string studentId, string issueDate, double fineAmount)
            : base(bookId, title, author)
        {
            StudentID = studentId;
            IssueDate = issueDate;
            FineAmount = fineAmount;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("\n======== Issued Book Details ========");
            Console.WriteLine($"Book ID      : {BookID}");
            Console.WriteLine($"Title        : {Title}");
            Console.WriteLine($"Author       : {Author}");
            Console.WriteLine($"Student ID   : {StudentID}");
            Console.WriteLine($"Issue Date   : {IssueDate}");
            Console.WriteLine($"Fine Amount  : {FineAmount}");

            if (FineAmount > 0)
            {
                Console.WriteLine("Status       : Book Returned Late");
            }
            else
            {
                Console.WriteLine("Status       : Returned On Time");
            }
        }
    }
}
