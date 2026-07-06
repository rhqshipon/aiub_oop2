using System;

namespace task3;
internal class Program
{
    public static void Main(string[] args)
    {
        StudentManager m1 = new StudentManager();
        m1.AddStudents();
        m1.DisplayStudentData();

        BookManager bm1 = new BookManager();
        bm1.AddBooks();
        bm1.DisplayBookData();
    }
}