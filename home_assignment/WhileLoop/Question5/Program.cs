using System;
namespace WhileLoop5;
class Program
{
    public static void Main(string[] args)  
{   
    int i=1;
    int res=0;
    while(i<=3)
    {
        Console.WriteLine("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        res+=num;
        i++;
    }
    
    Console.WriteLine("sum ="+res);  
}  
}