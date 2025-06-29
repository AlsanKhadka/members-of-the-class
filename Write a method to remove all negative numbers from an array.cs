//Write a method to remove all negative numbers from an array.
public class Home
{
    public void Method(params int[] num)
    {
        
        int i = 0,j=0;
        while (i<num.Length)
        {
            if (num[i] > 0)
            {
                num[j] = num[i];
                j++;
            }
            i++;
            
        }
       int[] num1 = new int[j];
        

        for (int k = 0; k < num1.Length; k++)
        {
            num1[k] = num[k];
            Console.WriteLine(num1[k]);
        }
    }
    public static void Main()
    {
        Home home = new Home();
        home.Method ( new int[] { 1, -2, 3 });
    }
}