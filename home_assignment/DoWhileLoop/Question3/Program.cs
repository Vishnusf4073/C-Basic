using System;
namespace DoWhile;
class Program
{
    static void Main(string[] args)
    {
        int i=1;
        Console.WriteLine("Enter Number of Fibonacci Values Needed : ");
        int n =Convert.ToInt32(Console.ReadLine());
        int f=0;
        int f1=1;
        int f2=1;

         do
    {
        i++;
       Console.Write(f+" ");
        f1=f2;
        f2=f;
        f=f1+f2;
    }
    while(i<=n);
    }
}
