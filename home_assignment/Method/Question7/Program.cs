using System;
public class Example
{
    public static bool checkPalindrome(string inputString)
        {
          char[] c = inputString.ToCharArray();
          Array.Reverse(c);
          return new string(c).Equals(inputString);
        }
    public static void Main()
        {
            Console.Write("Enter the string:");
            string str=Console.ReadLine();
             Console.Write(checkPalindrome(str));
            
        }
}      
