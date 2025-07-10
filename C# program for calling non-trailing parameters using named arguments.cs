//C# program for calling non-trailing parameters using named arguments
using System.Security.Cryptography.X509Certificates;

public class Home
{
    public void PersonalInfo(string name, int age,string address="Arghakhanchi")
    {
        Console.WriteLine($"My name is {name}, my age is {age} and my address is {address}");
    }
    public static void Main()
    {
        Home home = new Home();
        home.PersonalInfo("Alsan Khadka",age:19);
    }
}