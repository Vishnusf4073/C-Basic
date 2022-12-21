using System;
namespace question5
{
    class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Meters = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int CM=m*100;
            Console.WriteLine("CM = "+CM);
            Console.WriteLine("MM = "+CM*10);
            Console.WriteLine("INches = "+m*39.3);
            Console.WriteLine("Foot = "+12*m);
            Console.WriteLine("Miles = "+0.0006213715277778 * m);
        }

    }
}
