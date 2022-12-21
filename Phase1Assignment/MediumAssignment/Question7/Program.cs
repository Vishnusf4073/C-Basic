using System;  
namespace While;
  public class FibonacciExample  
   {  
     public static void Main(string[] args)  
      {  
        int count=0,sum=0;
         Console.Write("Enter the Starting number: ");
         int num=Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter the Difference number: ");
         int num1=Convert.ToInt32(Console.ReadLine());
         Console.Write("Enter the  number of Element: ");
         int num2=Convert.ToInt32(Console.ReadLine());
         count=num;
         for(int i =0; i<num2; i++)
         {
            Console.Write(count+" ");
            sum+=count;
            count=count+num1;
            
         }
         Console.WriteLine("\n\nsum="+sum);
      }  
   }  
