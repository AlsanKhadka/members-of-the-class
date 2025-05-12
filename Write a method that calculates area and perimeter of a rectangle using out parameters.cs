//Write a method that calculates area and perimeter of a rectangle using out parameters.
public class OutUsages
{
    public static void Main()
    {
        int l, b,area,perimeter;
       
        AreaParameter(out l, out b, out area, out perimeter);
        Console.WriteLine($"The area of the triangle is {area}");
        Console.WriteLine($"The perimeter of the triangle is {perimeter}");
    }
    public static void AreaParameter(out int length,out int breadth, out int area1, out int perimeter1)
    {
        Console.Write("Enter your length ");
        length = int.Parse(Console.ReadLine());
        Console.Write("Enter your breadth ");
       breadth = int.Parse(Console.ReadLine());
        area1 = length * breadth;
        perimeter1 = 2*(length + breadth);
    }
}