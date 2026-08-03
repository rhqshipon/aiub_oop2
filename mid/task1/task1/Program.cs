

namespace task1;

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("This is a simple C# program.");
        Calculator calculator = new Calculator(10, 5);
        calculator.display();

        KedaBoro kedaBoro = new KedaBoro();
        Console.Write("Enter a number: ");
        kedaBoro.number = Double.Parse(Console.ReadLine());
        kedaBoro.checkKedaBoro();
    }
}