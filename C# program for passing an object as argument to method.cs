//C# program for passing an object as argument to method
public class Program
{
    public int value;
    public void SetValue(int v)
    {
        value = v;
    }
    public void PrintValue()
    {
        Console.WriteLine($"The value is {value}");
    }
    public void Addobj(Program obj1, Program obj2)
    {
        value = obj1.value + obj2.value;
    }
}
public class Person
{
    public static void Main()
    {
        Program obj1 = new Program();
        Program obj2 = new Program();
        Program obj3 = new Program();
        obj1.SetValue(10);
        obj2.SetValue(20);
        obj3.Addobj(obj1,obj2);
        obj1.PrintValue();
        obj2.PrintValue();
        obj3.PrintValue();

    }
}