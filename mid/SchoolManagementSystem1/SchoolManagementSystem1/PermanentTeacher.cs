using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagementSystem1
{
    internal class PermanentTeacher : Teacher
    {
        private double medicalAllowance;
        private double yearlyIncrement;

        internal PermanentTeacher(string id, string name, double basicSalary, string joiningDate, double medicalAllowance, double yearlyIncrement)
            : base(id, name, basicSalary, joiningDate)
        {
            this.medicalAllowance = medicalAllowance;
            this.yearlyIncrement = yearlyIncrement;
        }

        internal double getMedicalAllowance() { return medicalAllowance; }
        internal double getYearlyIncrement() { return yearlyIncrement; }

        internal new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Medical Allowance: " + medicalAllowance);
            Console.WriteLine("Yearly Increment: " + yearlyIncrement);
            Console.WriteLine("Gross Income: " + GrossIncome());
        }

        internal override double GrossIncome()
        {
            return getBasicSalary() * 12 + medicalAllowance * 12 + yearlyIncrement;
        }

    }
}
