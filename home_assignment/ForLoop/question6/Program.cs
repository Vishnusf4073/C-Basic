using System;
namespace ForLoop1;
class Program
{
    public static void Main(string[] args)
    {
        
        for (int i=0;i<4;i++)
        {
            for (int j=0;j<=i;j++)
            {
                Console.Write("*"); 
            }
           Console.Write("\n"); 
        }
    }
}