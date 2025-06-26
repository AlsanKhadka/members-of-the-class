//Write a method to check if a string is a palindrome.
namespace Namespace1
{
    public class Home
    {
       public bool IsPalindrome(string name)
        {
            name= name.ToLower();
            string reverseName = "";
            for(int i = 0; i < name.Length; i++)
            {
         reverseName= name[i]+reverseName;
            }
            if(reverseName == name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main()
        {
            Home home = new Home();
            if (home.IsPalindrome("mom"))
            {
                Console.WriteLine($"The name is palindrome ");
            }
            else
            {
                Console.WriteLine($"The name is not palindrome ");
            }
        }
    }

}