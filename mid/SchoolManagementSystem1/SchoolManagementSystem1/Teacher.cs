using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolManagementSystem1
{
    internal abstract class Teacher
    {
        private string id;
        private string name;
        private double basicSalary;
        private string joiningDate;

        internal Teacher(string id, string name, double basicSalary, string joiningDate)
        {
            this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;
            this.joiningDate = joiningDate;
        }

        internal string getId() { return id; }
        internal string getName() { return name; }
        internal double getBasicSalary() { return basicSalary; }
        internal string getJoiningDate() { return joiningDate; }

        internal void ShowInfo()
        {
            Console.WriteLine("Teacher ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Joining Date: " + joiningDate);
            Console.WriteLine("Basic Salary: " + basicSalary);
        }

        internal abstract double GrossIncome();
    }
}
