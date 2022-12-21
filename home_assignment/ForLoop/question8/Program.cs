

    class Program
    {
        static void Main(string[] args)
        {
            int num, i, j, k;
            num=4;
            int  h=1;
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num-i+1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    
                    Console.Write(h);
                    Console.Write(" ");
                    h++;
                }
                Console.WriteLine();

            }
        }
    }