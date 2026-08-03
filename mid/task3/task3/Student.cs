
using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    struct Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Cgpa { get; set; }
    }

    class StudentManager
    {
        private Student[] students = new Student[5];

        public void AddStudents()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nEntering details for Student {i + 1}:");

                Console.Write("Enter ID: ");
                string id = Console.ReadLine();

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter CGPA: ");
                float cgpa = float.Parse(Console.ReadLine());

                students[i] = new Student { Id = id, Name = name, Cgpa = cgpa };
            }
        }

        public void DisplayStudentData()
        {
            Console.WriteLine("\n--- Student Records ---");
            
            foreach (Student s in students)
            {
                if (s.Cgpa >= 3.5)
                {
                    Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, CGPA: {s.Cgpa}");
                }
            }
        }
    }
}