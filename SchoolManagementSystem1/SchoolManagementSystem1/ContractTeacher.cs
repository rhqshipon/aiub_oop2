using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagementSystem1
{
    internal class ContractTeacher : Teacher
    {
        private double perClassPayment;
        private float totalClassesPerMonth;

        internal ContractTeacher(string id, string name, double basicSalary, string joiningDate, double perClassPayment, float totalClassesPerMonth)
            : base(id, name, basicSalary, joiningDate)
        {
            this.perClassPayment = perClassPayment;
            this.totalClassesPerMonth = totalClassesPerMonth;
        }

        internal new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Per Class Payment: " + perClassPayment);
            Console.WriteLine("Total Classes Per Month: " + totalClassesPerMonth);
            Console.WriteLine("Gross Income: " + GrossIncome());
        }

        internal override double GrossIncome()
        {
            return perClassPayment * totalClassesPerMonth * 12;
        }

    }

}
