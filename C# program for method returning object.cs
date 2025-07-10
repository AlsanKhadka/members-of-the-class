//C# program for method returning object
namespace Namespace1
{
    public class Home
    {
        public int Age;
        public string Name;
        public Home()
        {
            Age = 19;
            Name = "Ram";
        }
        public static Home Method1()
        {
            return new Home();
        }
    }
    public class Person
    {
        public static void Main()
        {
           Home home= Home.Method1();
            Console.WriteLine($"My name is {home.Name} and my age is {home.Age}");
        }
    }
}