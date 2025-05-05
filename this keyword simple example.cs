//this keyword simple example
public class Program
{
    private int a;
    private int b;
    public Program()
    {
        a = 0;
        b = 0;
    }
    public void ThisImplement(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public void Print()
    {
        Console.WriteLine($"The value of a is {a}");
        Console.WriteLine($"The value of b is {b}");
    }
}
public class Person
{
    public static void Main()
    {
        Program obj = new Program();
        obj.ThisImplement(10, 20);
        obj.Print();
    }
}