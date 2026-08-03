using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace labexamtask1
{
    internal class Employee
    {
        internal string EmployeeID { get; set; }
        internal string EmployeeName { get; set; }
        internal string Department { get; set; }
        internal double Salary { get; set; }
        internal static int TotalEmployees { get; private set; }

        internal Employee(string employeeID, string employeeName, string department, double salary)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Department = department;
            Salary = salary;
            TotalEmployees++;
        }
    }

    internal class EmployeeManager
    {
        private Employee[] emp = new Employee[5];

        internal void AddEmployee()
        {
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}:");

                Console.Write("Employee ID: ");
                string employeeID = Console.ReadLine();

                Console.Write("Employee Name: ");
                string employeeName = Console.ReadLine();

                Console.Write("Department: ");
                string department = Console.ReadLine();

                double salary = Convert.ToDouble(Console.ReadLine());

                emp[i] = new Employee(employeeID, employeeName, department, salary);
            }
        }

        internal void DisplayEmployees()
        {
            Console.WriteLine("\n--- Employee List ---");
            foreach (Employee e in emp)
            {
                if (e != null)
                {
                    Console.WriteLine($"ID: {e.EmployeeID}, Name: {e.EmployeeName}, Department: {e.Department}, Salary: {e.Salary}");
                }
            }
        }

        internal void FindHighestSalary()
        {
            if (emp[0] == null) return;

            Employee highest = emp[0];

            for (int i = 1; i < emp.Length; i++)
            {
                if (emp[i] != null && emp[i].Salary > highest.Salary)
                {
                    highest = emp[i];
                }
            }

            Console.WriteLine("\n--- Highest Salary Employee ---");
            Console.WriteLine($"Name: {highest.EmployeeName}, Department: {highest.Department}, Salary: {highest.Salary}");
        }
    }
}