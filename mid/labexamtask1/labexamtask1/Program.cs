namespace labexamtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();
            manager.AddEmployee();
            manager.DisplayEmployees();
            manager.FindHighestSalary();
            Console.WriteLine($"\nTotal Employees Created: {Employee.TotalEmployees}");
            Console.ReadLine();
        }
    }
}

