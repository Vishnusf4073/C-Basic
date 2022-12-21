using System;
namespace String11;
{
     class Program
    {
        static void Main(string[] args)
        {
            String str1;
            str1="aaaaaabbbbccc";
            Console.WriteLine("Input String: "+str1);
            Console.WriteLine("After removing duplicates characters from the said string:");
            Console.WriteLine(removeDuplicate(str1));
            str1="Python";
            Console.WriteLine("Input String: "+str1);
            Console.WriteLine("After removing duplicates characters from the said string:");
            Console.WriteLine(removeDuplicate(str1));
            str1="Java";
            Console.WriteLine("Input String: "+str1);
            Console.WriteLine("After removing duplicates characters from the said string:");
            Console.WriteLine(removeDuplicate(str1));
        }

     static String removeDuplicate(string str)
{
    int index = 0;
    int n=str.Length;
    
    for (int i = 0; i < n; i++)
    {
        int j;
        for (j = 0; j < i; j++) 
        {
            if (str[i] == str[j])
            {
                break;
            }
        }
     
        if (j == i) 
        {
            string strt[index++] = str[i];
        }
    }
    char [] ans = new char[index];
    Array.Copy(str, ans, index);
    return String.Join("", ans);
}
  }
}
