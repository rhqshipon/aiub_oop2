namespace task2;

public class Program
{
    public static void Main(string[] args)
    {
        //TaskA taskA = new TaskA();
        //taskA.FindLargest();

        //TaskB taskB = new TaskB();
        //taskB.MatrixSum();

        //TaskC taskC = new TaskC();
        //taskC.JaggedArray();

        ArrayAnalyzer a1 = new ArrayAnalyzer();
        a1.ReadElements();
        a1.FindAndPrintLargest();

        StudentMarksTracker t1 = new StudentMarksTracker();
        t1.ReadStudentData();
        t1.CalculateAndPrintResults();

        Matrix m1 = new Matrix();
        m1.ReadElements();
        m1.PrintAndSum();
    }
}