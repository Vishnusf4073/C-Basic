using System;
namespace switch_assignment;
    class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Enter the Radius of Circle: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1)area :+ \n2)Perimeter :");
            Console.WriteLine("Enter your Choice: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            switch(temp)
            {
                case 1:
                {
                    Console.WriteLine("the area: "+(3.14*r*r));
                    break;
                }
                case 2 :
                {
                    Console.WriteLine("the perimeter : "+(2*3.14*r));
                    break;
                }
                
             }
        }
    }