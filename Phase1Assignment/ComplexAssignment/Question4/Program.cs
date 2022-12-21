using System;
namespace Question4;

     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str1=Console.ReadLine();
            Console.WriteLine("Input: "+str1);
            Console.Write("Output:");
            removeDuplicate(str1);
            
        
 void removeDuplicate(string str)
{
   
    int n=str.Length;
    char[] strt=new char[10];
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
             Console.Write(str[i]);
        }
    }
    
   
}
  }
}

