    using System;
    namespace Question9;
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, j, k;
            num=7;
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num-i+1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
               i++;
            }
        }
    }