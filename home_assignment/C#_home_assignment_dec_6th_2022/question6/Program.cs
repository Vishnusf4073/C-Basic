using System;
namespace question5
{
    class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Price = ");
            int p = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Total_price = "+(p+(p*0.18)));
           
        }

    }
}
