namespace SchoolManagementSystem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the School Management System!");
            // Additional code for the school management system can be added here.

            PermanentTeacher pt1 = new PermanentTeacher("001", "Iftekharul Mubin", 100000, "22-JUL-2023", 1000, 100);
            pt1.ShowInfo();

            Console.WriteLine("\n");

            ContractTeacher ct1 = new ContractTeacher("002", "DU er pride somponno low income teacher looking for more bread", 10, "22-JUL-2025", 100, 8);
            ct1.ShowInfo();
        }
    }
}