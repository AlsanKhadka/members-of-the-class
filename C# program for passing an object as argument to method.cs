//C# program for passing an object as argument to method
namespace Namespace1
{
    public class Home
    {
        public string name;
        public int age;
        public Home()
        {
            name = "Alsan Khadka";
            age = 19;
        }
        public static void Method(Home home)
        {
            Console.WriteLine($"My name is {home.name} and my age is {home.age}");
        }
    }
}
public class Person
{
    public static void Main()
    {
      Namespace1.Home home = new Namespace1.Home();
        Namespace1.Home.Method(home);
    }
}