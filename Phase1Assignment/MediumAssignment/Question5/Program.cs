using System;  
namespace Question7;
class Program
{  
    public static void Main() 
  {
    Console.Write("Enter the year: ");
    int num= Convert.ToInt32(Console.ReadLine());
    int i=0;
    while ( i<=num)
    {
        i=i+4;
        Console.Write(i+" ");
    }
  }
}
