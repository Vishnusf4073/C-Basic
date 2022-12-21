using System;
namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i     = 0;
            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 30; i++)
            {   
                if( i%2 == 0 )
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            for (i = 1; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\nPrime numbers are:");
            int count = 0;
        for (int k = 2; k <= 100; k++)
        {
        for (int j = 2; j <= 100; j++)
        {
        if(k%j==0)
        count++;
        }
        if (count == 1) 
        {
    Console.Write(k+" ");
    }
    count = 0;
    }
            Console.WriteLine();
        }
    }
}