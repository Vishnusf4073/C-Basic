using System;
namespace Question10;
class Program
{
    static void Main(string[] args)
    {
        for (int i=0;i<22;i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int i =0; i<4;i++)
        {
            for(int j =0; j<2;j++)
            {
                Console.Write("*");
                Console.Write("\t\t     ");
            }
            Console.WriteLine();
        }
        for (int i=0;i<22;i++)
        {
            Console.Write("*");
        }
    }
}