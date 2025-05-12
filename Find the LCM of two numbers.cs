//Find the LCM of two numbers
using System.Numerics;

public class Program
{
    public static void Main()
    {
        int num1, num2;
        int small = 0, big = 0;
        Console.Write("Enter number1 ");
        bool A = int.TryParse(Console.ReadLine(), out num1);
        Console.Write("Enter number2 ");
        bool B = int.TryParse(Console.ReadLine(), out num2);
        if (num1 > num2)
        {
            big = num1;
        }
        else
        {
            big = num2;
        }
        if (num1 < num2)
        {
            small = num1;
        }
        else
        {
            small = num2;
        }
        int gcd1 = GCD(big, small);
        int LCM = big * small/gcd1;
        Console.WriteLine($"The LCM is {LCM}");
    }
    public static int GCD(int num1, int num2)
    {
        int gcd = 1;
        while (gcd != 0)
        {
           gcd = num1 % num2;
            num1 = num2;
            num2 = gcd;
         
        }
        return num1;
    }
    
}
