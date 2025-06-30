//Write a method that swaps two numbers using ref keyword
public class Home
{
    public static void SwapNumbers(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;

    }
    public static void Main()
    {
        int num1 = 10, num2 = 20;
        Console.WriteLine($"Before swapped num1: {num1} num2: {num2}");
        Home.SwapNumbers(ref num1, ref num2);
        Console.WriteLine($"After swapped num1: {num1} num2: {num2}");
    }
}