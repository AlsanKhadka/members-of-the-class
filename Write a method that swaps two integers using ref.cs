//Write a method that swaps two integers using ref.
public class Program
{
    public static void Main()
    {
        int a = 30, b = 20;
        Console.WriteLine($"The value of a is {a} and the value of b is {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"The value of a is {a} and the value of b is {b}");
    }
    public static void Swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
}